 class Application
   def main
     n = get_numbers
     puts "#{n.min} #{n.max}"
   end
   def get_numbers : Array
     gets
     return gets.to_s.chomp.split(" ").map(&.to_i)
   end
end

Application.new.main

