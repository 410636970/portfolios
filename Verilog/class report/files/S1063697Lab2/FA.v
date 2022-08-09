`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    17:13:18 10/21/2019 
// Design Name: 
// Module Name:    FA 
// Project Name: 
// Target Devices: 
// Tool versions: 
// Description: 
//
// Dependencies: 
//
// Revision: 
// Revision 0.01 - File Created
// Additional Comments: 
//
//////////////////////////////////////////////////////////////////////////////////
module FA( // gate-level modeling
input x,y,z,
output S,C);

wire w1, w2, w3;

xor x1(w1, x, y);
xor x2(S, w1, z);
and a1(w2, x, y);
and a2(w3, w1, z);
or o1(C, w2, w3);
endmodule
