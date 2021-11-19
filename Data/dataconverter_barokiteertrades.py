import csv
import datareader, datawriter
import data_extractor_warframe_blueprints
import data_extractor_weapon_blueprints
import name_filter

def extract_cost_from_cost_strings_array(cost_name, cost_strings):
   result = 0
   for cost_string in cost_strings:
      if not cost_name in cost_string:
         continue
      split_string = cost_string.split('Â\xa0')
      cost_string = split_string[0].strip()
      cost_string = cost_string.replace(',', '')
      result = int(cost_string)
   return result

def extract_cost_from_entry(cost_entry):
   cost_strings = cost_entry.split('+')
   credits_cost = extract_cost_from_cost_strings_array('Credits', cost_strings)
   ducats_cost = extract_cost_from_cost_strings_array('Ducats', cost_strings)
   return [credits_cost, ducats_cost]

def process_row_data(row):
   result = []
   item_name = row[0]
   cost_entry = row[1]
   dates_string = row[2]
   
   cost = extract_cost_from_entry(cost_entry)
   cost_credits = cost[0]
   cost_ducats = cost[1]
   dates = dates_string.split('\n')
   
   for date in dates:
      result.append([item_name, cost_credits, cost_ducats, date])
   return result

raw_file_name = 'warframewiki_BaroKiteerOfferings'
data_raw = datareader.read_csv(raw_file_name)
datareader.remove_first_columns(data_raw, 2)

out_data = []
for row in data_raw:
   processed_row = process_row_data(row)
   out_data += processed_row_data

datawriter.write_csv('BaroKiteerTradeHistory', out_data)