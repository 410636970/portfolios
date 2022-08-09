module ALU_MSB_test; // ´ú¸Õ¼Ò²Õ
	// Inputs
	reg a;
	reg b;
	reg Ainvert;
	reg Binvert;
	reg CarryIn;
	reg [1:0] Operation;
	reg Less;

	// Outputs
	wire Result, Overflow, Set;

	// Instantiate the Unit Under Test (UUT)
	ALU_MSB uut (
		.a(a), 
		.b(b), 
		.Ainvert(Ainvert), 
		.Binvert(Binvert), 
		.CarryIn(CarryIn), 
		.Operation(Operation), 
		.Less(Less), 
		.Result(Result), 
		.Overflow(Overflow),
      .Set(Set)
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
		#10 Binvert = 1;
#10 Operation = 3;
		#10;
		
      a = 1;
		b = 1;
		Ainvert = 0;
		Binvert = 0;
		CarryIn = 1;
		Operation = 0;
		Less = 1;

		#10 Operation = 1;
		#10 Operation = 2;
		#10 Binvert = 1;
#10 Operation = 3;
		#10 $finish;

		end
endmodule
