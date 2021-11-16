import os, csv
import datareader, datawriter
import name_filter
import data_extractor_item_sources

def print_table(table, tablename = 'unnamed'):
   table_length = len(table)
   print('Items in ' + tablename + ' table: ' + str(table_length))
   for row in table:
      print(row)

def sort_by_column(list, column_index):
   list.sort(key = lambda row: row[column_index])

component_category_name = 'Component'
resource_category_name = 'Resource'


item_sources = datareader.read_item_source_files()
for source_row in item_sources:
   item_link = source_row[0]
   item_name = data_extractor_item_sources.get_name_from_link(item_link)
   source_row[0] = item_name


# drops_data = data_extractor_item_sources.extract_drops_data(item_sources)
# sort_by_column(drops_data, 0)
# print_table(drops_data, 'Item Drops')

void_relics_data = data_extractor_item_sources.extract_void_relic_contents_data(item_sources)
sort_by_column(void_relics_data, 0)
print_table(void_relics_data, 'Void Relics')