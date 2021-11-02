import asyncio
import websockets

async def connectionSetup(websocket,path):
    serverConnectionMessage = await websocket.recv()
    print("Message Recieved: " + serverConnectionMessage)

async def server():
    async with websockets.serve(connectionSetup, "192.168.1.158", 8765):
        await asyncio.Future()

print("Running Server")
asyncio.run(server())
print("Server end")