`timescale 1ns / 1ps
//////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer: 
// 
// Create Date:    17:16:35 09/21/2016 
// Design Name: 
// Module Name:    adder_4bit 
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
module adder_4bit(
	 input [3:0] A,
	 input [3:0] B,
    output [3:0] Sum,
    output Cout
    );

	wire C1,C2,C3;
	
	FA FA0(A[0],B[0],1'b0,Sum[0],C1);
	FA FA1(A[1],B[1],C1,Sum[1],C2);
	FA FA2(A[2],B[2],C2,Sum[2],C3);
	FA FA3(A[3],B[3],C3,Sum[3],Cout);
endmodule

module FA(
	 input x,
	 input y,
	 input z,
    output S,
    output C
    );
	 
	xor x1(w1,x,y);
	xor x2(S,w1,z);
	and a1(w2,x,y);
	and a2(w3,w1,z);
	or  o1(C,w2,w3);
endmodule 