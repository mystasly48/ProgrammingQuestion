# -*- encoding: utf-8 -*-
class Application
  def main
    puts make_alphabet.join(' ')
  end

  def make_alphabet : Array
    return ('A'..'Z').to_a.sample(get_code)
  end

  def get_code : Int32
    return gets.to_s.to_i
  end
end

Application.new.main
