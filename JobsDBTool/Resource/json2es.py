# -*- coding: utf-8 -*-  
import sys, time
from datetime import datetime
from elasticsearch import Elasticsearch

filePath = 'D:\dev_local\PythonDemo\HKPREWEB1.UnhandledEx.20170809.log'
host = '10.1.9.55'
port = 9200
index = 'analyze_log_index'
type = 'web_log'

def batch(filePath, host, index, type):
	es = Elasticsearch([host])
	import elasticsearch.helpers

	package = []
	file_object = open(filePath)
	try:
		 package = eval(file_object.read())
	finally:
		 file_object.close( )
	
	actions = []
	batchIndex = 0
	batchSize = 100
	totalIndex = 0
	for d in package:
		totalIndex = totalIndex + 1
		if batchIndex <= batchSize:
			batchIndex = batchIndex + 1
		else:
			batchIndex = 1
			actions = []
		d["@timestamp"] = datetime.now().strftime( "%Y-%m-%dT%H:%M:%S.000+0800" )
		actions.append({
			'_op_type': 'index',
			'_index': index,
			'_type': type,
			'_source': d
		})
		if batchIndex > batchSize or totalIndex >= len(package):
			elasticsearch.helpers.bulk(es, actions)
	
if __name__ == "__main__":
	args = sys.argv[1:]
	if not args:
		print("not args")
		args = [filePath, host, index, type]
		
	filePath = args[0]
	host = args[1]
	index = args[2]
	type = args[3]

	print("Paramaters:")
	print("filePath: " + filePath)
	print("host: " + host)
	print("port: %d" % port)
	print("index: " + index)
	print("type: " + type)
	
	t = time.time()
	batch(filePath, host, index, type)
	
	print("total run time:")
	e = time.time()
	print(e-t)
