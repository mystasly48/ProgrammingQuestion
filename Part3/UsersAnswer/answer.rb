 puts ((n, m = gets, gets.chomp.split(' ').map(&:to_i))[1].reduce{ |sum, n| n + (sum *= 1.08)}).round(0)
