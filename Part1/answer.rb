puts gets.chomp.split(' ').map(&:to_i).reduce(:+)
