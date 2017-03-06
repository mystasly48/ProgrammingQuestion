n, cards, input, add = gets.to_i, gets.chomp.split(" ").map(&:to_i), [], []
cards.each { |card| input << card if cards.inject(Hash.new(0)){|h, key| h[key] += 1; h}.map {|k,v| k if v >= 2}.compact.include?(card) }
input.uniq.each{ |i| cards.delete(i) }
a = input.group_by{ |it| it }
a.each_value{ |v| add <<  v[0] if v.size % 2 != 0 }
add
puts (add.empty? && cards.empty? ? 0 : (cards + add).sort.join(" "))
