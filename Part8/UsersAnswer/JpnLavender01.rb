puts (a = ((gets.chomp + gets.chomp).split(''))).select{|e| a.index(e)!=a.rindex(e)}.uniq.count
