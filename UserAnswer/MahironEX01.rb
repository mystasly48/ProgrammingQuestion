puts gets.split(' ').map(&:to_i).inject{|sum, n|sum + n} 
