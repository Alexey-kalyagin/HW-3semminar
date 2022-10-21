
import controller
import model
import view

if model.change_ver():
   
    model.init_first()
    while True:
            
        if model.init_ops():
            break
        model.init_second()
        controller.operation()
        view.print_total()
            
        model.first = model.total
else:
    view.print_gor_ver()
    model.add_string() 
