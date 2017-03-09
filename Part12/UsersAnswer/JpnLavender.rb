require 'pry'

class String
  def tinpooo
    tables = self.split("").group_by{ |it| it }
    x, y = tables.keys
    return  (tables[x].length > tables[y].length ? y : x)
  end

  def oppai_x(houkei_tinpo)
    return houkei_tinpo.index(self) + 1
  end
  def oppai_y(kyonyu)
    count = 1
    kyonyu.each do |v|
      v.include?(self) ?  break : count += 1
    end
    return count
  end
end

class App
  def initialize
    @tikubi, @fera = gets.chomp.split("").map(&:to_i)
    @dick = Array.new
    @tinpo = String.new
  end

  def main
    get_table(@tikubi)
    target = @tinpo.tinpooo
    y = target.oppai_y(@dick)
    x = target.oppai_x(@dick[y-1])
    puts ("#{x} #{y}")
  end

  def get_table(tikubi)
    tikubi.times{ @dick << gets.chomp }
    @tinpo = @dick.join("")
    return @tinpo
  end
end

app = App.new
app.main
