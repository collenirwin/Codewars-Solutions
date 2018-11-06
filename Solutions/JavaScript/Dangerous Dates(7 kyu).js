var nextFiveDays = function(date) {
    const dates = [];
    
    for (var i = 0; i < 5; i++) {
      date.setDate(date.getDate() + 1);
      
      const day = date.getDate(),
        month = date.getMonth() + 1,
        year = date.getYear() + 1900;
        
      dates.push(month + '/' + day + '/' + year);
    }
    
    return dates.join(', ');
}