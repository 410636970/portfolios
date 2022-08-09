
# PlanAhead Launch Script for Post PAR Floorplanning, created by Project Navigator

create_project -name S1063697Lab1 -dir "C:/Users/student/Desktop/ooo/S1063697Lab1/planAhead_run_3" -part xc3s100ecp132-4
set srcset [get_property srcset [current_run -impl]]
set_property design_mode GateLvl $srcset
set_property edif_top_file "C:/Users/student/Desktop/ooo/S1063697Lab1/S1063697Lab1.ngc" [ get_property srcset [ current_run ] ]
add_files -norecurse { {C:/Users/student/Desktop/ooo/S1063697Lab1} }
set_property target_constrs_file "Lab1.ucf" [current_fileset -constrset]
add_files [list {Lab1.ucf}] -fileset [get_property constrset [current_run]]
link_design
read_xdl -file "C:/Users/student/Desktop/ooo/S1063697Lab1/S1063697Lab1.ncd"
if {[catch {read_twx -name results_1 -file "C:/Users/student/Desktop/ooo/S1063697Lab1/S1063697Lab1.twx"} eInfo]} {
   puts "WARNING: there was a problem importing \"C:/Users/student/Desktop/ooo/S1063697Lab1/S1063697Lab1.twx\": $eInfo"
}
