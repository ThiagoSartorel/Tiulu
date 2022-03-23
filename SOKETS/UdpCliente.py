import socket

def Main():
    # cria o socket UDP do cliente, abrindo uma porta alta
    mySocket = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    print('Cliente Python UDP: {}'.format( mySocket.getsockname )  )
    
    # define o endereço e porta do servidor de destino
    servidorDestino = ('127.0.0.1', 10000)
    
    while True:
        # aguarda o usuário digitar uma mensagem
        message = input(" -> (q sair) ")

        if message == 'q':
            break
        
        # envia a mensagem do usuário para o servidorDestino
        sent = mySocket.sendto(message.encode(), servidorDestino)
        
        # fica em wait ate que uma mensagem chegue
        # recebe e mostra a mensagem devolvida pelo servidor
        data, server = mySocket.recvfrom(4096)
        print('Recebido do servidor {}: {}'.format(server, data.decode()))
        #print( str(s.recv(4096), 'utf-8') )
   
    mySocket.close()

if __name__ == '__main__':
    Main()