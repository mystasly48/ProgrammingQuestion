class Application
  def main
    puts processing get_input_data
  end

  def processing(value)
    if value[0] =~ /#{value[1]}/
      return true
    else
      return false
    end
  end

  def get_input_data : Array
    return [gets.to_s.chomp, gets.to_s.chomp]
  end
end

Application.new.main
