puts ((n, m = gets, gets.chomp.split(' ').map(&:to_i))[1].map{|v| v *= 1.08 }.reduce(:+)).round(0)
