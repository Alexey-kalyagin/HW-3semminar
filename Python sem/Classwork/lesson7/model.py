import string
from tabnanny import verbose
import controller
import view

first = 0
second = 0
ops = ''
total = 0
ver = 0
number = ''

def change_ver():
    global ver
    ver = int(input('Выберите версию калькулятора\n 1 - вертикальный\n 2 - горизонтальный\n'))
    if ver == 1:
        view.print_vert_ver()
        return True

def init_first():
    global first
    first = controller.input_integer("Введите число: ")
   
def init_second():
    global second
    second = controller.input_integer("Введите число: ")

def init_ops():
    global ops
    ops = controller.input_operation('Введите операцию: ')
    if ops == '=':
        view.print_total()
        return True

def add_string():
    global number
    number = input('Введите пример\n\n')
    if number[-1]== '=':
        number = number.replace('=','')
    print(eval(number))