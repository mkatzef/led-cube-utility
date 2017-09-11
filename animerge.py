import json
import sys
import os


def merge_animation_strings(string1, string2):
    """ Parses the given animation strings, combines the animations they represent
        (string2 appended to string1), returns the resulting animation string. """
    
    animation1 = json.loads(string1)
    animation2 = json.loads(string2)
    
    sizes_match = True
    if animation1["Width"] != animation2["Width"]:
        sizes_match = False
        print("Animation widths do not match.")
        
    if animation1["Length"] != animation2["Length"]:
        sizes_match = False
        print("Animation lengths do not match.")
    
    if animation1["Height"] != animation2["Height"]:
        sizes_match = False
        print("Animation heights do not match.")
    
    if sizes_match:
        result = dict(animation1.items())  # deep copy
        len1 = animation1["FrameCount"]
        len2 = animation2["FrameCount"]
        result["FrameCount"] = len1 + len2
        
        for i in range(len2):
            import_frame = animation2["Frame%d" % i]
            result["Frame%d" % (len1 + i)] = import_frame
        
        return json.dumps(result)
    

    
def main(f1, f2, f3):
    """ Reads f1 and f2, combines them to produce a new valid animation,
        then writes the animation to f3. """
    out_contents = ""
    
    with open(f1, 'r') as infile1:
        with open(f2, 'r') as infile2:
            s1 = infile1.read()
            s2 = infile2.read()
            out_contents = merge_animation_strings(s1, s2)
    
    with open(f3, 'w') as outfile:
        outfile.write(out_contents)

    
if __name__ == "__main__":
    argv = sys.argv
    
    if (argv[0] in ["python", "py", "python3"]):
        argv.pop(0)
    
    prog_name = argv.pop(0)
    usage_text = "usage: {0} animation1 animation2 output".format(prog_name)
    
    if (len(argv) != 3):
        print(usage_text)
    else:
        animfile1, animfile2, outfile = argv
        
        files_are_valid = True
        if not os.path.isfile(animfile1):
            files_are_valid = False
            print("File not found: \"{0}\"".format(animfile1))
            
        if not os.path.isfile(animfile2):
            files_are_valid = False
            print("File not found: \"{0}\"".format(animfile2))
        
        if not files_are_valid:
            print(usage_text)
        else:
            main(animfile1, animfile2, outfile)
        
                