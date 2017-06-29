#!/usr/bin/env python
# -*- coding: utf-8 -*-  
#coding=utf-8  
#copy files
import os, sys, re
import shutil
import time

configPath = "D:\web\configBK.txt"			#保存需要拷贝的文件路径
sourceDir = "D:\\jobsDBv8\\"				#需要拷贝的文件的共用路径 sourceDir为空时表示configPath文本里的是完整路径
#如果需要拷贝的文件的是全路径，则需要把路径中的sourceDir替换为空
re_ReplaceSourceDir = re.compile('^D:[\\|\\\\|/]jobsDBv8[\\|\\\\|/]', re.I)
targetDir = "D:\\bkTask\\"					#保存路径targetDir\today\...
isComment = "False"							#是否需要加入说明targetDir\today_说明\...
isAddToday = "False"						#是否需要在备份路径中增加一个today日期的文件夹
isBKWording = "False"						#是否需要备份wording
wordingFilePath = "D:\\workspaces\\JobsDBTool\\bin\\Debug\\Resource\\InputData.csv"
filterFileTypes = [".vsmdi", ".bat"]	#需要过滤的文件类型

#拷贝文件的函数
def copyFile(sourceFile, targetFile):
	if os.path.isfile(sourceFile):								#判断待复制的文件是否存在
		try:
			'''
			#方法一
			index = targetFile.rfind("/")						#目标路径中最后一个/的位置   i.e. c:/path
			if index == -1:										#如果不存在/， 那么就是用\	   i.e. c:\path
				ext_dir = targetFile[:targetFile.rfind("\\")]	#得到文件所在的文件夹路径   
			else:
				ext_dir = targetFile[:targetFile.rfind("/")]	#得到文件所在的文件夹路径   
			'''
			#方法二
			targetFile = targetFile.replace('\\', '/')			#替换路径中的 \ 为 /			
			#ext_dir = os.path.dirname(targetFile)				#得到文件所在的文件夹路径
			ext_dir = os.path.split(targetFile)[0]				#os.path.split(path) 把路径分成文件夹路径和文件名

			if not os.path.exists(ext_dir):						#如果文件夹不存在就创建文件夹
				os.makedirs(ext_dir)
#			else:
#				print(ext_dir)

			shutil.copy(sourceFile, targetFile)					#开始拷贝文件

			print('copied ' + sourceFile + '\n' + ' to ' + targetFile + '\n')
		except:
			print('copied except from ' + sourceFile + '\nto ' + targetFile + '\n')
	else:
		print('not exists file %s' % sourceFile)

def CreateDir(todayDir, index):
	newDir = "%s%s%d%s"%(todayDir, "_V", index, "\\")
	if not os.path.exists(newDir):
		os.makedirs(newDir)
	else:
		newDir, index = CreateDir(todayDir, index+1)
	return (newDir, index)

#获得所有待拷贝的文件和目标路径
def BKFiles(configPath, sourceDir, targetDir, isComment = "False", isAddToday = "False", filterFileTypes = []):
	fileObject = open(configPath)										#打开存放路径的文本
	fileList = []
	try:
		for line in fileObject:
			fileList.append(line.strip('\n'))							#把所有路径加入到list中，并去读取文本行后面的符号\n
	finally:
		fileObject.close()
	fileList = dict.fromkeys(fileList, True)							#把list转成dict， 可以运行的更快
	
	if isAddToday == "True":
		today = time.strftime('%Y%m%d')										#得到今天的日期
		if isComment == "True":												#是否需要给备份加入注释 
			comment = raw_input("Enter a comment:")							#提示输入注释
			if len(comment) == 0:
				todayDir = targetDir + today							#生成备份文件夹名  i.e. 20130510
			else:
				todayDir = targetDir + today + "_" + comment			#生成备份文件夹名  i.e. 20130510_comment
		else:
			todayDir = targetDir + today
	else:
		todayDir = targetDir


	#if not os.path.exists(todayDir):									#如果文件夹不存在就创建文件夹
	#	os.makedirs(todayDir)
#		print('Successful created directory')
	todayDir, index = CreateDir(todayDir, 1)

	count = 0
	for f in fileList:												#循环拷贝文件
		#print("--%s--" % f)
		if f != "":
			#判断文件是否是要过滤的类型
			#os.path.splitext(filename) 把文件名分成文件名称和扩展名	
			if os.path.splitext(f)[1] not in filterFileTypes:
				try:
					#判断文件是否直接是个文件路径
					if os.path.isfile(f):
						short = re_ReplaceSourceDir.sub('', f)
						copyFile(sourceDir + short, todayDir + short)
					else:
						if sourceDir == "":
							copyFile(sourceDir + f, todayDir)
						else:
							copyFile(sourceDir + f, todayDir + f)
						count = count + 1
				except:
					pass
			else:
				print("filtered " + f + "\n")
	print("copied %d file(s)\n" % count)
	return index

if __name__ == "__main__":											#如果不是import此python，那么开始备份文件
	args = sys.argv[1:]
	if not args:
		print("not args")
		args = [configPath, sourceDir, targetDir, isComment, isAddToday, isBKWording]

	configPath = args[0]
	sourceDir = args[1]
	targetDir = args[2]
	isComment = args[3]
	isAddToday = args[4]
	if len(args) > 5:
		isBKWording = args[5]
	if len(args) > 6:
		wordingFilePath = args[6]

	print("Paramaters:")
	print("configPath:" + configPath + ".")
	print("sourceDir:" + sourceDir + ".")
	print("targetDir:" + targetDir + ".")
	print("isComment:" + isComment + ".")
	print("isAddToday:" + isAddToday + ".")
	print("isBKWording:" + isBKWording + ".\n")

	t = time.time()
	index = BKFiles(configPath, sourceDir, targetDir, isComment, isAddToday, filterFileTypes)
	
	if isBKWording == "True":		
		#newName = os.path.splitext(wordingFilePath)[0] + " " + time.strftime('%Y%m%d') + "_V" + str(index) + os.path.splitext(wordingFilePath)[1]		
		newName = "%s %s_V%d%s"%(os.path.splitext(wordingFilePath)[0], time.strftime('%Y%m%d'), index, os.path.splitext(wordingFilePath)[1])
		copyFile(wordingFilePath, targetDir + os.path.basename(newName))
		print("bk wording file")
	print("total run time:")
	print(time.time()-t)
