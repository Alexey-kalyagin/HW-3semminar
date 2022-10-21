
import logger
import view
import model

def input_integer(enter):
    while True:
        try:
            a = int(input(enter))
            return a
        except:
            view.error_valye()

def input_operation(enter):
    while True:
        a = input(enter)
        if a in ['+', '-', '*', '/', '=']:
            return a
        else:
            view.error_valye()


def operation():
    match (model.ops):
        case '+':
            model.total = model.first + model.second
        case '-':
            model.total = model.first - model.second
        case '*':
            model.total = model.first * model.second
        case '/':
            while model.second ==0:
                print("На 0 делить нельзя")
                model.init_second()
            model.total = int(model.first / model.second)
        case _:
            view.error_valye()
    logger.logger(f'{model.first}{model.ops}{model.second} = {model.total}')