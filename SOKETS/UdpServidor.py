#!/usr/bin/env python
import socket, sys, os

def Main():
    host = "127.0.0.1"
    port = 10000

    # cria o socket UDP do servidor (Internet,Transporte)
    socketUDP = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    # configura o IP e a porta que o servidor vai ficar executando
    socketUDP.bind((host, port))
    print('Servidor Python UDP: {}:{}'.format(host, port))

    while True:
        print('Aguardando mensagens...')
        # fica aguardando até que chegue uma mensagem
        data, address = socketUDP.recvfrom(4096)  # buffer size - bytes
        print('Recebido {} bytes de {}'.format(len(data), address))
        #print(data)

        # devolve para o cliente a mensagem maiúscula
        if data:
            anexo = ' - Abc Bolinhas'
            mensagem = (data.upper() + anexo.encode())
            print(mensagem)
            sent = socketUDP.sendto(mensagem, address)
        else:
            break

    socketUDP.close()


if __name__ == '__main__':
    try:
        Main()
    except KeyboardInterrupt:
        print('Interrupted')
        try:
            sys.exit(0)
        except SystemExit:
            os._exit(0)