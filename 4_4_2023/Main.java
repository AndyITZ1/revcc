public class Main {
    static class VoteCount {
        int upvotes;
        int downvotes;

        VoteCount(int up, int down) {
            upvotes = up;
            downvotes = down;
        }
    }

    public static int getVoteCount(VoteCount votes) {
        return votes.upvotes - votes.downvotes;
    }

    public static void main(String[] args) {
        System.out.println(getVoteCount(new VoteCount(13, 0)));
        System.out.println(getVoteCount(new VoteCount(2, 33)));
        System.out.println(getVoteCount(new VoteCount(132, 132)));
    }
}