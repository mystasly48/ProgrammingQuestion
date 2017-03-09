class String
  def ちんぽぉ
    tables = self.split("").group_by{ |it| it }
    x, y = tables.keys
    return  (tables[x].length > tables[y].length ? y : x)
  end

  def oppai_x(グラビア_巨乳)
    return グラビア_巨乳.index(self) + 1
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
    @ちくび, @ふぇら = gets.chomp.split(" ").map(&:to_i)
    @ちんこ = Array.new
    @巨乳 = String.new
  end

  def main
    get_table(@ふぇら)
    target = @巨乳.ちんぽぉ
    y = target.oppai_y(@ちんこ)
    x = target.oppai_x(@ちんこ[y-1])
    puts ("#{x} #{y}")
  end

  def get_table(ふぇら)
    ふぇら.times{ @ちんこ << gets.chomp }
    @巨乳 = @ちんこ.join("")
    return @巨乳
  end
end

app = App.new
app.main
