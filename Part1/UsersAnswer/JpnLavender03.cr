class Application
  def main
    puts input_processing.calculation
  end

  def input_processing : Array
    gets.to_s.split(' ').map(&.to_i)
  end
end

class Array
  def calculation
   self.reduce{ |sum, n| sum + n }
  end
end

Application.new.main
