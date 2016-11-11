class QuestionAnswer
  def main
    puts processing(input_data_processing)
  end
  def processing(value : Array) : Int32
    return ( (value[1] / value[2]) * value[3] / (value[0] + 1) ) * 2
  end
  def input_data_processing : Array
    return gets.to_s.split(' ').map(&.to_i)
  end
end
QuestionAnswer.new.main
