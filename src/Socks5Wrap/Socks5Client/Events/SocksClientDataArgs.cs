﻿/*
    Socks5 - A full-fledged high-performance socks5 proxy server written in C#. Plugin support included.
    Copyright (C) 2016 ThrDev

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace Socks5Wrap.Socks5Client.Events
{
    public class Socks5ClientDataArgs : EventArgs
    {
        public Socks5ClientDataArgs(Socks5Client client, byte[] buff, int count, int offset)
        {
            _cli = client;
            Buffer = buff;
            Count = count;
            Offset = offset;
        }
        //Data Buffer
        //Socks Client
        private Socks5Client _cli;
        public Socks5Client Client { get { return _cli; } }
        public byte[] Buffer { get; set; }
        public int Count { get; set; }
        public int Offset { get; set; }
    }
}
