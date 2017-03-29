class Integer
    def exchange
          ary = []
              self.to_s.split("").each do |v|
                      v = v.to_i
                            if v> 5
                                      ary << [1,v-5]
                                            else
                                                      ary << [0,v]
                                                            end
                                end
                  x = ary.flatten
                      return "0 " * (8 - x.length) + x.join(" ")
                        end
end

class App
    def main
          have_money = gets.to_i
              gets.to_i.times { have_money -= gets.to_i }
                  puts have_money.exchange
                    end
end

App.new.main
