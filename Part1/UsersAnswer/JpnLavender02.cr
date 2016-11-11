puts gets.to_s.split(' ').map(&.to_i).reduce{ |sum, n| sum + n }
