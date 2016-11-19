 class Application
   def main
     puts num_count( uniq_processing(value_split(get_code)) )
   end

   def num_count(value : Array) : Int32
     i = 0
     return value.count{ |v| v }
   end

   def uniq_processing(value : Array) : Array
     return value.select{|e| value.index(e)!=value.rindex(e)}.uniq
   end

   def value_split(value : String) : Array
     return value.split("")
   end

   def get_code : String
     return (gets.to_s.chomp + gets.to_s.chomp)
   end
end

Application.new.main
