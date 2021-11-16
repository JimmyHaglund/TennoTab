import csv
import os

unstitched_directory = '1_Unstitched'
final_directory = '2_Final'
suffix = '.csv'

def working_path(folder_name):
   working_directory = os.getcwd()
   return os.path.join(working_directory, folder_name)

def write_csv(name, data):
   target_directory = working_path(final_directory)
   file_name = name + suffix
   path = os.path.join(target_directory, file_name)
   with open(path, 'w', newline="") as outfile:
      writer = csv.writer(outfile, delimiter=",")
      for row in data:
         writer.writerow(row)