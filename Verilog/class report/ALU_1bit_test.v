`timescale 1ns / 1ps

////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer:
//
// Create Date:   10:24:59 12/19/2016
// Design Name:   ALU_1bit
// Module Name:   C:/data/course/Verilog/ALU_1bit/ALU_1bit_test.v
// Project Name:  ALU_1bit
// Target Device:  
// Tool versions:  
// Description: 
//
// Verilog Test Fixture created by ISE for module: ALU_1bit
//
// Dependencies:
// 
// Revision:
// Revision 0.01 - File Created
// Additional Comments:
// 
////////////////////////////////////////////////////////////////////////////////

module ALU_1bit_test;

	// Inputs
	reg a;
	reg b;
	reg Ainvert;
	reg Binvert;
	reg CarryIn;
	reg [1:0] Operation;
	reg Less;

	// Outputs
	wire Result;
	wire CarryOut;

	// Instantiate the Unit Under Test (UUT)
	ALU_1bit uut (
		.a(a), 
		.b(b), 
		.Ainvert(Ainvert), 
		.Binvert(Binvert), 
		.CarryIn(CarryIn), 
		.Operation(Operation), 
		.Less(Less), 
		.Result(Result), 
		.CarryOut(CarryOut)
	);

	initial begin
		// Initialize Inputs
		a = 0;
		b = 0;
		Ainvert = 0;
		Binvert = 0;
		CarryIn = 0;
		Operation = 0;
		Less = 0;

		#10 a = 0;
		b = 1;
		Ainvert = 0;
		Binvert = 0;
		CarryIn = 1;
		Operation = 0;
		Less = 0;

		#10 Operation = 1;
		#10 Operation = 2;
		#10 Operation = 3;
		#10;
		
      a = 1;
		b = 1;
		Ainvert = 0;
		Binvert = 1;
		CarryIn = 1;
		Operation = 0;
		Less = 1;

		#10 Operation = 1;
		#10 Operation = 2;
		#10 Operation = 3;
		#10 $finish;

		end

endmodule

