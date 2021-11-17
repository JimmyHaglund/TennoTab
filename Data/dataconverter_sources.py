import os, csv
import datareader, datawriter
import name_filter
import data_extractor_item_sources
import subprocess

def print_table(table, tablename = 'unnamed'):
   table_length = len(table)
   print('Items in ' + tablename + ' table: ' + str(table_length))
   for row in table:
      print(row)

def sort_by_column(list, column_index):
   list.sort(key = lambda row: row[column_index])

component_category_name = 'Component'
resource_category_name = 'Resource'

print('Starting conversion of scraped item source data.')

print('Reading item source scape files...')
item_sources = datareader.read_item_source_files()
for source_row in item_sources:
   item_link = source_row[0]
   item_name = data_extractor_item_sources.get_name_from_link(item_link)
   source_row[0] = item_name
print('Done')

print('Processing data...')
drops_data = data_extractor_item_sources.extract_drops_data(item_sources)
void_relics_data = data_extractor_item_sources.extract_void_relic_contents_data(item_sources)
market_price_data = data_extractor_item_sources.extract_market_items_data(item_sources)
syndicate_offerings_data = data_extractor_item_sources.extract_syndicate_offerings_data(item_sources)
print('Done')

print('Sorting data...')
sort_by_column(drops_data, 0)
sort_by_column(void_relics_data, 0)
sort_by_column(market_price_data, 0)
sort_by_column(syndicate_offerings_data, 0)
print('Done')

print('Writing processed data files...')
datawriter.write_csv('ItemDrops', drops_data)
datawriter.write_csv('VoidRelicDrops', void_relics_data)
datawriter.write_csv('MarketItems', market_price_data)
datawriter.write_csv('SyndicateOfferings', syndicate_offerings_data)
print('Done')

print('Scraped data conversion complete.')

# print_table(drops_data, 'Item Drops')
# print_table(void_relics_data, 'Void Relics')
# print_table(market_price_data, 'Market Prices')
# print_table(syndicate_offerings_data, 'Syndicate Offerings')