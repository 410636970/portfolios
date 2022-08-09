`timescale 1ns / 1ps

////////////////////////////////////////////////////////////////////////////////
// Company: 
// Engineer:
//
// Create Date:   01:58:00 11/28/2019
// Design Name:   add3
// Module Name:   C:/Users/JV/Desktop/ooo4/s1063697Lab4/add3_test.v
// Project Name:  s1063697Lab4
// Target Device:  
// Tool versions:  
// Description: 
//
// Verilog Test Fixture created by ISE for module: add3
//
// Dependencies:
// 
// Revision:
// Revision 0.01 - File Created
// Additional Comments:
// 
////////////////////////////////////////////////////////////////////////////////

module add3_test;

	// Inputs
	reg A3;
	reg A2;
	reg A1;
	reg A0;

	// Outputs
	wire S3;
	wire S2;
	wire S1;
	wire S0;

	// Instantiate the Unit Under Test (UUT)
	add3 uut (
		.A3(A3), 
		.A2(A2), 
		.A1(A1), 
		.A0(A0), 
		.S3(S3), 
		.S2(S2), 
		.S1(S1), 
		.S0(S0)
	);
	
	reg [3:0] A;
	initial begin
        // Initialize Inputs
        for (A=0; A<10; A=A+1) begin
            {A3,A2,A1,A0} = A;
            #10;
        end 
        $finish;
    end

      
endmodule

