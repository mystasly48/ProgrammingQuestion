require 'time'

class String
  def time_parse
    datetime = self.split(" ")
    d = datetime[0..2].join("-")
    t = datetime[3..5].join(":")
    return Time.parse("#{d} #{t}")
  end
end

time_1 = gets.chomp.time_parse
time_2 = gets.chomp.time_parse

puts (  (time_2 - time_1) / (60*60) ).ceil
