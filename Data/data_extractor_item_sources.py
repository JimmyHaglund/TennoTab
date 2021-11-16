
def get_name_from_link(item_link):
   item_link_split = item_link.split('/')
   item_name = item_link_split.pop()
   if item_name == 'Prime':
      item_name = item_link_split.pop() + ' ' + item_name

   item_name = item_name.replace('_', ' ').replace('%26', '&').replace('%27', "'")
   return item_name
      

def extract_drops_data(source_data):
   result = []
   for data_row in source_data:
      # Table structure: [ItemName, DropSource, DropChance]
      item_name = data_row[0]
      source_name = data_row[1]
      drop_chance = data_row[2]
      if nullorempty(source_name) or nullorempty(drop_chance):
         continue
      drop_chance = float(drop_chance.replace('%', ''))
      result.append([item_name, source_name, drop_chance])
   return result


def extract_table_header_titles_from_table_row(table_row_data):
   result = []
   before_title = '<th style="text-align:center;">'
   after_title = '</th>'
   header_data = table_row_data.split(before_title)
   header_data.pop(0)
   for header_data_row in header_data:
      title = header_data_row.split(after_title)[0].strip()
      result.append(title)
   return result

def extract_rarity_from_text(text):
   rarities = ['Common', 'Uncommon', 'Rare']
   for rarity in rarities:
      if rarity in text:
         return rarity
   return ''

def extract_relic_drop_data_from_table_body_column(item_name, table_body_data):
   result = []
   entries_data = table_body_data.split('data-param="')
   entries_data.pop(0)
   for entry_data in entries_data:
      relic_name = entry_data.split('"').pop(0)
      rarity = extract_rarity_from_text(entry_data)
      result.append([relic_name, item_name, rarity])
   return result

def extract_void_relic_contents_data(source_data):
   result = []
   for data_row in source_data:
      name = data_row[0]
      if not 'Prime' in name:
         continue
      raw_data = data_row[3]
      table_rows = raw_data.split('<tr>')
      if len(table_rows) < 3:
         # print('table rows for ' + name + ' is under 3, skipping')
         continue
      header_data = table_rows[1]
      body_data = table_rows[2]
      body_columns = body_data.split('<td style="text-align:center; font-size:12px;">')
      body_columns.pop(0)
      header_titles = extract_table_header_titles_from_table_row(header_data)
      # print('len body/headers' + str(len(body_columns)) + '/' + str(len(header_titles)))
      for n in range(0, len(header_titles)):
         title = header_titles[n]
         body = body_columns[n]
         item_name = name + ' ' + title
         source_entries = extract_relic_drop_data_from_table_body_column(item_name, body)
         result += source_entries
      # result.append([])
      # result.append(raw_data)
      # print(prime_data)
   # Table structure: [RelicName, ItemName, Rarity]
   # print('void relic extraction not implemented')
   return result



def extract_market_items_data(source_data):
   #result = []
   # for data_row in source_data:
      
   # Table structure: [ItemName, CreditsPrice]
   print('market items data extraction not implemented')
   return []

def extract_syndicate_offerings_data(source_data):
   # Table structure: [ItemName, SyndicateName, RankRequired, ReputationCost]
   print('syndicate offerings data extraction not implemented')
   return []

def extract_quest_rewards_data(source_data):
   # Table structure: [ItemName, QuestName]
   print('quest rewards data extraction not implemented')
   return []

def extract_invasion_rewards_data(source_data):
   # Table structure: [ItemName, InvasionDate, InvasionType]
   print('invasion rewards data extraction not implemented')
   return []

def extract_barookiteer_items_data(source_data):
   # Table structure: [SaleDate, ItemName, DucatsCost]
   print('barookiteer items data extraction not implemented')
   return []

def extract_kuva_items_data(source_data):
   # Table structure: [ItemName]
   print('kuva items data extraction not implemented')
   return []

def extract_login_rewards_data(source_data):
   # Table structure: [ItemName, DaysRequired]
   print('login rewards data extraction not implemented')
   return []

def extract_researched_item_replication_costs_data(source_data):
   # Table structure: [ItemName, LabName, CreditsCost]
   print('researched item replication costs data extraction not implemented')
   return []

def nullorempty(value):
   return len(value) == 0 or value == 'null'