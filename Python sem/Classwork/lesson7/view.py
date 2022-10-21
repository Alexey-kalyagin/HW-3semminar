
import model
import logger

def error_valye():
    logger.logger('Ошибка ввода')
    return print('Ошибка ввода')

def print_total():
    
    return print(f'Результат: {model.total}')

def print_vert_ver():
    print('Вы выбрали вертикальный калькулятор\n\n')

def print_gor_ver():
    print('Вы выбрали горизонтальный калькулятор\n')