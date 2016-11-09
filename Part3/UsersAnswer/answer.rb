(N, m, a = gets, gets.chomp.split(' '), [])[1].map{ |v| a << (v * 1.08).round(0) }

puts a.reduce(:+)
