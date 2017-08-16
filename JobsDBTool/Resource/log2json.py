# -*- coding: utf-8 -*-  
import os, sys, re
import shutil
import time

#re.match  match startç   re.search match anywhere
regexs = {
	'TicketStart': '^(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2},\d*),\[(\d*)\],(\D*),(.*),(\D*),"Helpdesk Ticket:(.*)',
	'ErrorStart': '^(\d{4}-\d{2}-\d{2} \d{2}:\d{2}:\d{2},\d*),\[(\d*)\],(\D*),(.*)',
	'ExceptionTargetStart': '^Exception Target Site:(.*)',
	'ExceptionTargetEnd': '^---- ASP.NET Collections ----',
	'TicketParam': '^{0}:*(.*)',
	'TicketObj': '^{0}',
	'TicketObj_Param': '^\s+(\S+)\s+(.*)'
}
logFilePath = ""
jsonFilePath = "json_log\json.txt"
logs = []
log_keys = [
	"Date and Time", "Machine Name" , "Process User" , "Remote User", "Remote Address", 
	"Remote Host", "URL", "NET Runtime version", "Application Domain", 
	"Assembly Codebase", "Assembly Full Name", "Assembly Version", 
	"Assembly Build Date", "Exception Type", "Exception Message", "Exception Source"]
log_obj_key = ["Form", "Cookies", "Session", "ServerVariables"]

def WriteFile(filePath):
	ext_dir = os.path.split(filePath)[0]
	if not os.path.exists(ext_dir):	
		os.makedirs(ext_dir)
				
	f = open(filePath, 'w')
	f.write(repr(logs))
	f.close()

def ReadFile(filePath):
	log = {}
	cur_key = ''
	bCurError = False
	if os.path.isfile(filePath):
		bCurException = False
		
		f = open(filePath)
		lines = f.readlines()
		
		for line in lines:
			line = line.decode('utf-8', 'ignore').encode('gbk', 'ignore')
			matchObj = re.match(regexs['TicketStart'], line, re.M|re.I)
			if matchObj:
				if(log.has_key('UTCDate')):
					logs.append(log)
					log = {}
					cur_key = ''
					bCurException = False
					bCurError = False
				log["Id"] = matchObj.group(1).strip().replace(" ", "").replace("-", "").replace(":", "").replace(",", "")
				log["UTCDate"] = matchObj.group(1).strip()
				log["Thread"] = matchObj.group(2).strip()
				log["Level"] = matchObj.group(3).strip()
				log["LogId"] = matchObj.group(4).strip()
				log["LogType"] = matchObj.group(5).strip()
				log["TicketId"] = matchObj.group(6).strip()
				continue
			
			matchObj = re.match(regexs['ErrorStart'], line, re.M|re.I)
			if matchObj:
				if(log.has_key('UTCDate')):
					logs.append(log)
					log = {}
					cur_key = ''
					bCurException = False
					bCurError = False
				log["Id"] = matchObj.group(1).strip().replace(" ", "").replace("-", "").replace(":", "").replace(",", "")
				log["UTCDate"] = matchObj.group(1).strip()
				log["Thread"] = matchObj.group(2).strip()
				log["Level"] = matchObj.group(3).strip()
				log["Exception"] = matchObj.group(4).strip()
				continue
			if bCurError:
				log["Exception"] += '\r\n' + line
				continue

			matchObj = re.match(regexs['ExceptionTargetStart'], line, re.M|re.I)
			if matchObj:
				bCurException = True
				log["ExceptionTargetSite"] = matchObj.group(1).strip()
				continue
			matchObj = re.match(regexs['ExceptionTargetEnd'], line, re.M|re.I)
			if matchObj:
				bCurException = False
				continue
			if bCurException:
				log["ExceptionTargetSite"] += '\r\n' + line;
				continue
			
			for key in log_keys:
				matchObj = re.search(regexs['TicketParam'].replace("{0}", key), line, re.M|re.I)
				if matchObj:
					log[key] = matchObj.group(1).strip()
					break

			bMatch = False
			for obj_key in log_obj_key:
				matchObj = re.match(regexs['TicketObj'].replace("{0}", obj_key), line, re.M|re.I)
				if matchObj:
					bMatch = True
					cur_key = obj_key
					break
			if bMatch:
				continue
			
			matchObj = re.match(regexs['TicketObj_Param'], line, re.M|re.I)
			if matchObj and cur_key != '':
				if not log.has_key(cur_key):
					log[cur_key] = {}
				log[cur_key][matchObj.group(1).strip()] = matchObj.group(2).strip()
				continue
			
		#for the lastest log info
		if(log.has_key('UTCDate')):
			logs.append(log)
		f.close()
	else:
		print('not exists file: %s' % filePath)

if __name__ == "__main__":
	args = sys.argv[1:]
	if not args:
		print("not args")
		args = [logFilePath, jsonFilePath]

	logFilePath = args[0]
	jsonFilePath = args[1]

	print("Paramaters:")
	print("logFilePath:" + logFilePath)
	print("jsonFilePath:" + jsonFilePath)
	
	t = time.time()
	ReadFile(logFilePath)
	WriteFile(jsonFilePath)
	
	print("total run time:")
	print(time.time()-t)
	