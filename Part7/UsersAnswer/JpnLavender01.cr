 class Application

   def main
     while true
       next unless zun
       puts doko ? "キヨシ！"  : "ズコー！"
       exit
     end
   end

   def zun : Bool
     i = 0
     4.times { (i += 1) if "ズン" == get_code }
     return (i == 4 ? true : false)
   end

   def doko : Bool
     "ドコ" == get_code
   end

   def get_code : String
     gets.to_s.chomp
   end
end

Application.new.main

