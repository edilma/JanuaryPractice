# TODO: complete this class
import math 

class PaginationHelper:

  # The constructor takes in an array of items and a integer indicating
  # how many items fit within a single page
  def __init__(self, collection, items_per_page):
      self.collection = collection
      self.items_per_page = items_per_page
      
  
  # returns the number of items within the entire collection
  def item_count(self):
      count = len (self.collection)
      return count
      
  
  # returns the number of pages
  def page_count(self):
      pages = math.ceil(self.item_count()/self.items_per_page)
      return pages
      
	
  # returns the number of items on the current page. page_index is zero based
  # this method should return -1 for page_index values that are out of range
  def page_item_count(self,page_index):
      maxPages = self.page_count()-1
      if page_index>maxPages or page_index<0:
          return -1
      else:
          itemsPage = self.item_count()/self.page_count()
          return itemsPage
  
  # determines what page an item is on. Zero based indexes.
  # this method should return -1 for item_index values that are out of range
  def page_index(self,item_index):
    if item_index>= self.item_count() or item_index<0:
        return -1
    else:
        position = (math.ceil(((item_index+1)/self.items_per_page)))-1
        return position
      
def main():
    collection = ['a','b','c','d','e','f']

    helper = PaginationHelper(collection,4)
    print ("Page Count is ", helper.page_count())
    print ("Item count is", helper.item_count())
    print ("The number of items in page 4 is: {0}, -1 if that page doesn't exits ".format(helper.page_item_count(3)))

if __name__ == "__main__":
    main()
