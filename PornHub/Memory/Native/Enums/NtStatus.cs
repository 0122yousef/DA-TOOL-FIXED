using System;

namespace PornHub.Memory.Native.Enums
{
	// Token: 0x0200001F RID: 31
	public enum NtStatus : uint
	{
		// Token: 0x040002F5 RID: 757
		Success,
		// Token: 0x040002F6 RID: 758
		Wait0 = 0U,
		// Token: 0x040002F7 RID: 759
		Wait1,
		// Token: 0x040002F8 RID: 760
		Wait2,
		// Token: 0x040002F9 RID: 761
		Wait3,
		// Token: 0x040002FA RID: 762
		Wait63 = 63U,
		// Token: 0x040002FB RID: 763
		Abandoned = 128U,
		// Token: 0x040002FC RID: 764
		AbandonedWait0 = 128U,
		// Token: 0x040002FD RID: 765
		AbandonedWait1,
		// Token: 0x040002FE RID: 766
		AbandonedWait2,
		// Token: 0x040002FF RID: 767
		AbandonedWait3,
		// Token: 0x04000300 RID: 768
		AbandonedWait63 = 191U,
		// Token: 0x04000301 RID: 769
		UserApc,
		// Token: 0x04000302 RID: 770
		KernelApc = 256U,
		// Token: 0x04000303 RID: 771
		Alerted,
		// Token: 0x04000304 RID: 772
		Timeout,
		// Token: 0x04000305 RID: 773
		Pending,
		// Token: 0x04000306 RID: 774
		Reparse,
		// Token: 0x04000307 RID: 775
		MoreEntries,
		// Token: 0x04000308 RID: 776
		NotAllAssigned,
		// Token: 0x04000309 RID: 777
		SomeNotMapped,
		// Token: 0x0400030A RID: 778
		OpLockBreakInProgress,
		// Token: 0x0400030B RID: 779
		VolumeMounted,
		// Token: 0x0400030C RID: 780
		RxActCommitted,
		// Token: 0x0400030D RID: 781
		NotifyCleanup,
		// Token: 0x0400030E RID: 782
		NotifyEnumDir,
		// Token: 0x0400030F RID: 783
		NoQuotasForAccount,
		// Token: 0x04000310 RID: 784
		PrimaryTransportConnectFailed,
		// Token: 0x04000311 RID: 785
		PageFaultTransition = 272U,
		// Token: 0x04000312 RID: 786
		PageFaultDemandZero,
		// Token: 0x04000313 RID: 787
		PageFaultCopyOnWrite,
		// Token: 0x04000314 RID: 788
		PageFaultGuardPage,
		// Token: 0x04000315 RID: 789
		PageFaultPagingFile,
		// Token: 0x04000316 RID: 790
		CrashDump = 278U,
		// Token: 0x04000317 RID: 791
		ReparseObject = 280U,
		// Token: 0x04000318 RID: 792
		NothingToTerminate = 290U,
		// Token: 0x04000319 RID: 793
		ProcessNotInJob,
		// Token: 0x0400031A RID: 794
		ProcessInJob,
		// Token: 0x0400031B RID: 795
		ProcessCloned = 297U,
		// Token: 0x0400031C RID: 796
		FileLockedWithOnlyReaders,
		// Token: 0x0400031D RID: 797
		FileLockedWithWriters,
		// Token: 0x0400031E RID: 798
		Informational = 1073741824U,
		// Token: 0x0400031F RID: 799
		ObjectNameExists = 1073741824U,
		// Token: 0x04000320 RID: 800
		ThreadWasSuspended,
		// Token: 0x04000321 RID: 801
		WorkingSetLimitRange,
		// Token: 0x04000322 RID: 802
		ImageNotAtBase,
		// Token: 0x04000323 RID: 803
		RegistryRecovered = 1073741833U,
		// Token: 0x04000324 RID: 804
		Warning = 2147483648U,
		// Token: 0x04000325 RID: 805
		GuardPageViolation,
		// Token: 0x04000326 RID: 806
		DatatypeMisalignment,
		// Token: 0x04000327 RID: 807
		Breakpoint,
		// Token: 0x04000328 RID: 808
		SingleStep,
		// Token: 0x04000329 RID: 809
		BufferOverflow,
		// Token: 0x0400032A RID: 810
		NoMoreFiles,
		// Token: 0x0400032B RID: 811
		HandlesClosed = 2147483658U,
		// Token: 0x0400032C RID: 812
		PartialCopy = 2147483661U,
		// Token: 0x0400032D RID: 813
		DeviceBusy = 2147483665U,
		// Token: 0x0400032E RID: 814
		InvalidEaName = 2147483667U,
		// Token: 0x0400032F RID: 815
		EaListInconsistent,
		// Token: 0x04000330 RID: 816
		NoMoreEntries = 2147483674U,
		// Token: 0x04000331 RID: 817
		LongJump = 2147483686U,
		// Token: 0x04000332 RID: 818
		DllMightBeInsecure = 2147483691U,
		// Token: 0x04000333 RID: 819
		Error = 3221225472U,
		// Token: 0x04000334 RID: 820
		Unsuccessful,
		// Token: 0x04000335 RID: 821
		NotImplemented,
		// Token: 0x04000336 RID: 822
		InvalidInfoClass,
		// Token: 0x04000337 RID: 823
		InfoLengthMismatch,
		// Token: 0x04000338 RID: 824
		AccessViolation,
		// Token: 0x04000339 RID: 825
		InPageError,
		// Token: 0x0400033A RID: 826
		PagefileQuota,
		// Token: 0x0400033B RID: 827
		InvalidHandle,
		// Token: 0x0400033C RID: 828
		BadInitialStack,
		// Token: 0x0400033D RID: 829
		BadInitialPc,
		// Token: 0x0400033E RID: 830
		InvalidCid,
		// Token: 0x0400033F RID: 831
		TimerNotCanceled,
		// Token: 0x04000340 RID: 832
		InvalidParameter,
		// Token: 0x04000341 RID: 833
		NoSuchDevice,
		// Token: 0x04000342 RID: 834
		NoSuchFile,
		// Token: 0x04000343 RID: 835
		InvalidDeviceRequest,
		// Token: 0x04000344 RID: 836
		EndOfFile,
		// Token: 0x04000345 RID: 837
		WrongVolume,
		// Token: 0x04000346 RID: 838
		NoMediaInDevice,
		// Token: 0x04000347 RID: 839
		NoMemory = 3221225495U,
		// Token: 0x04000348 RID: 840
		NotMappedView = 3221225497U,
		// Token: 0x04000349 RID: 841
		UnableToFreeVm,
		// Token: 0x0400034A RID: 842
		UnableToDeleteSection,
		// Token: 0x0400034B RID: 843
		IllegalInstruction = 3221225501U,
		// Token: 0x0400034C RID: 844
		AlreadyCommitted = 3221225505U,
		// Token: 0x0400034D RID: 845
		AccessDenied,
		// Token: 0x0400034E RID: 846
		BufferTooSmall,
		// Token: 0x0400034F RID: 847
		ObjectTypeMismatch,
		// Token: 0x04000350 RID: 848
		NonContinuableException,
		// Token: 0x04000351 RID: 849
		BadStack = 3221225512U,
		// Token: 0x04000352 RID: 850
		NotLocked = 3221225514U,
		// Token: 0x04000353 RID: 851
		NotCommitted = 3221225517U,
		// Token: 0x04000354 RID: 852
		InvalidParameterMix = 3221225520U,
		// Token: 0x04000355 RID: 853
		ObjectNameInvalid = 3221225523U,
		// Token: 0x04000356 RID: 854
		ObjectNameNotFound,
		// Token: 0x04000357 RID: 855
		ObjectNameCollision,
		// Token: 0x04000358 RID: 856
		ObjectPathInvalid = 3221225529U,
		// Token: 0x04000359 RID: 857
		ObjectPathNotFound,
		// Token: 0x0400035A RID: 858
		ObjectPathSyntaxBad,
		// Token: 0x0400035B RID: 859
		DataOverrun,
		// Token: 0x0400035C RID: 860
		DataLate,
		// Token: 0x0400035D RID: 861
		DataError,
		// Token: 0x0400035E RID: 862
		CrcError,
		// Token: 0x0400035F RID: 863
		SectionTooBig,
		// Token: 0x04000360 RID: 864
		PortConnectionRefused,
		// Token: 0x04000361 RID: 865
		InvalidPortHandle,
		// Token: 0x04000362 RID: 866
		SharingViolation,
		// Token: 0x04000363 RID: 867
		QuotaExceeded,
		// Token: 0x04000364 RID: 868
		InvalidPageProtection,
		// Token: 0x04000365 RID: 869
		MutantNotOwned,
		// Token: 0x04000366 RID: 870
		SemaphoreLimitExceeded,
		// Token: 0x04000367 RID: 871
		PortAlreadySet,
		// Token: 0x04000368 RID: 872
		SectionNotImage,
		// Token: 0x04000369 RID: 873
		SuspendCountExceeded,
		// Token: 0x0400036A RID: 874
		ThreadIsTerminating,
		// Token: 0x0400036B RID: 875
		BadWorkingSetLimit,
		// Token: 0x0400036C RID: 876
		IncompatibleFileMap,
		// Token: 0x0400036D RID: 877
		SectionProtection,
		// Token: 0x0400036E RID: 878
		EasNotSupported,
		// Token: 0x0400036F RID: 879
		EaTooLarge,
		// Token: 0x04000370 RID: 880
		NonExistentEaEntry,
		// Token: 0x04000371 RID: 881
		NoEasOnFile,
		// Token: 0x04000372 RID: 882
		EaCorruptError,
		// Token: 0x04000373 RID: 883
		FileLockConflict,
		// Token: 0x04000374 RID: 884
		LockNotGranted,
		// Token: 0x04000375 RID: 885
		DeletePending,
		// Token: 0x04000376 RID: 886
		CtlFileNotSupported,
		// Token: 0x04000377 RID: 887
		UnknownRevision,
		// Token: 0x04000378 RID: 888
		RevisionMismatch,
		// Token: 0x04000379 RID: 889
		InvalidOwner,
		// Token: 0x0400037A RID: 890
		InvalidPrimaryGroup,
		// Token: 0x0400037B RID: 891
		NoImpersonationToken,
		// Token: 0x0400037C RID: 892
		CantDisableMandatory,
		// Token: 0x0400037D RID: 893
		NoLogonServers,
		// Token: 0x0400037E RID: 894
		NoSuchLogonSession,
		// Token: 0x0400037F RID: 895
		NoSuchPrivilege,
		// Token: 0x04000380 RID: 896
		PrivilegeNotHeld,
		// Token: 0x04000381 RID: 897
		InvalidAccountName,
		// Token: 0x04000382 RID: 898
		UserExists,
		// Token: 0x04000383 RID: 899
		NoSuchUser,
		// Token: 0x04000384 RID: 900
		GroupExists,
		// Token: 0x04000385 RID: 901
		NoSuchGroup,
		// Token: 0x04000386 RID: 902
		MemberInGroup,
		// Token: 0x04000387 RID: 903
		MemberNotInGroup,
		// Token: 0x04000388 RID: 904
		LastAdmin,
		// Token: 0x04000389 RID: 905
		WrongPassword,
		// Token: 0x0400038A RID: 906
		IllFormedPassword,
		// Token: 0x0400038B RID: 907
		PasswordRestriction,
		// Token: 0x0400038C RID: 908
		LogonFailure,
		// Token: 0x0400038D RID: 909
		AccountRestriction,
		// Token: 0x0400038E RID: 910
		InvalidLogonHours,
		// Token: 0x0400038F RID: 911
		InvalidWorkstation,
		// Token: 0x04000390 RID: 912
		PasswordExpired,
		// Token: 0x04000391 RID: 913
		AccountDisabled,
		// Token: 0x04000392 RID: 914
		NoneMapped,
		// Token: 0x04000393 RID: 915
		TooManyLuidsRequested,
		// Token: 0x04000394 RID: 916
		LuidsExhausted,
		// Token: 0x04000395 RID: 917
		InvalidSubAuthority,
		// Token: 0x04000396 RID: 918
		InvalidAcl,
		// Token: 0x04000397 RID: 919
		InvalidSid,
		// Token: 0x04000398 RID: 920
		InvalidSecurityDescr,
		// Token: 0x04000399 RID: 921
		ProcedureNotFound,
		// Token: 0x0400039A RID: 922
		InvalidImageFormat,
		// Token: 0x0400039B RID: 923
		NoToken,
		// Token: 0x0400039C RID: 924
		BadInheritanceAcl,
		// Token: 0x0400039D RID: 925
		RangeNotLocked,
		// Token: 0x0400039E RID: 926
		DiskFull,
		// Token: 0x0400039F RID: 927
		ServerDisabled,
		// Token: 0x040003A0 RID: 928
		ServerNotDisabled,
		// Token: 0x040003A1 RID: 929
		TooManyGuidsRequested,
		// Token: 0x040003A2 RID: 930
		GuidsExhausted,
		// Token: 0x040003A3 RID: 931
		InvalidIdAuthority,
		// Token: 0x040003A4 RID: 932
		AgentsExhausted,
		// Token: 0x040003A5 RID: 933
		InvalidVolumeLabel,
		// Token: 0x040003A6 RID: 934
		SectionNotExtended,
		// Token: 0x040003A7 RID: 935
		NotMappedData,
		// Token: 0x040003A8 RID: 936
		ResourceDataNotFound,
		// Token: 0x040003A9 RID: 937
		ResourceTypeNotFound,
		// Token: 0x040003AA RID: 938
		ResourceNameNotFound,
		// Token: 0x040003AB RID: 939
		ArrayBoundsExceeded,
		// Token: 0x040003AC RID: 940
		FloatDenormalOperand,
		// Token: 0x040003AD RID: 941
		FloatDivideByZero,
		// Token: 0x040003AE RID: 942
		FloatInexactResult,
		// Token: 0x040003AF RID: 943
		FloatInvalidOperation,
		// Token: 0x040003B0 RID: 944
		FloatOverflow,
		// Token: 0x040003B1 RID: 945
		FloatStackCheck,
		// Token: 0x040003B2 RID: 946
		FloatUnderflow,
		// Token: 0x040003B3 RID: 947
		IntegerDivideByZero,
		// Token: 0x040003B4 RID: 948
		IntegerOverflow,
		// Token: 0x040003B5 RID: 949
		PrivilegedInstruction,
		// Token: 0x040003B6 RID: 950
		TooManyPagingFiles,
		// Token: 0x040003B7 RID: 951
		FileInvalid,
		// Token: 0x040003B8 RID: 952
		InstanceNotAvailable = 3221225643U,
		// Token: 0x040003B9 RID: 953
		PipeNotAvailable,
		// Token: 0x040003BA RID: 954
		InvalidPipeState,
		// Token: 0x040003BB RID: 955
		PipeBusy,
		// Token: 0x040003BC RID: 956
		IllegalFunction,
		// Token: 0x040003BD RID: 957
		PipeDisconnected,
		// Token: 0x040003BE RID: 958
		PipeClosing,
		// Token: 0x040003BF RID: 959
		PipeConnected,
		// Token: 0x040003C0 RID: 960
		PipeListening,
		// Token: 0x040003C1 RID: 961
		InvalidReadMode,
		// Token: 0x040003C2 RID: 962
		IoTimeout,
		// Token: 0x040003C3 RID: 963
		FileForcedClosed,
		// Token: 0x040003C4 RID: 964
		ProfilingNotStarted,
		// Token: 0x040003C5 RID: 965
		ProfilingNotStopped,
		// Token: 0x040003C6 RID: 966
		NotSameDevice = 3221225684U,
		// Token: 0x040003C7 RID: 967
		FileRenamed,
		// Token: 0x040003C8 RID: 968
		CantWait = 3221225688U,
		// Token: 0x040003C9 RID: 969
		PipeEmpty,
		// Token: 0x040003CA RID: 970
		CantTerminateSelf = 3221225691U,
		// Token: 0x040003CB RID: 971
		InternalError = 3221225701U,
		// Token: 0x040003CC RID: 972
		InvalidParameter1 = 3221225711U,
		// Token: 0x040003CD RID: 973
		InvalidParameter2,
		// Token: 0x040003CE RID: 974
		InvalidParameter3,
		// Token: 0x040003CF RID: 975
		InvalidParameter4,
		// Token: 0x040003D0 RID: 976
		InvalidParameter5,
		// Token: 0x040003D1 RID: 977
		InvalidParameter6,
		// Token: 0x040003D2 RID: 978
		InvalidParameter7,
		// Token: 0x040003D3 RID: 979
		InvalidParameter8,
		// Token: 0x040003D4 RID: 980
		InvalidParameter9,
		// Token: 0x040003D5 RID: 981
		InvalidParameter10,
		// Token: 0x040003D6 RID: 982
		InvalidParameter11,
		// Token: 0x040003D7 RID: 983
		InvalidParameter12,
		// Token: 0x040003D8 RID: 984
		MappedFileSizeZero = 3221225758U,
		// Token: 0x040003D9 RID: 985
		TooManyOpenedFiles,
		// Token: 0x040003DA RID: 986
		Cancelled,
		// Token: 0x040003DB RID: 987
		CannotDelete,
		// Token: 0x040003DC RID: 988
		InvalidComputerName,
		// Token: 0x040003DD RID: 989
		FileDeleted,
		// Token: 0x040003DE RID: 990
		SpecialAccount,
		// Token: 0x040003DF RID: 991
		SpecialGroup,
		// Token: 0x040003E0 RID: 992
		SpecialUser,
		// Token: 0x040003E1 RID: 993
		MembersPrimaryGroup,
		// Token: 0x040003E2 RID: 994
		FileClosed,
		// Token: 0x040003E3 RID: 995
		TooManyThreads,
		// Token: 0x040003E4 RID: 996
		ThreadNotInProcess,
		// Token: 0x040003E5 RID: 997
		TokenAlreadyInUse,
		// Token: 0x040003E6 RID: 998
		PagefileQuotaExceeded,
		// Token: 0x040003E7 RID: 999
		CommitmentLimit,
		// Token: 0x040003E8 RID: 1000
		InvalidImageLeFormat,
		// Token: 0x040003E9 RID: 1001
		InvalidImageNotMz,
		// Token: 0x040003EA RID: 1002
		InvalidImageProtect,
		// Token: 0x040003EB RID: 1003
		InvalidImageWin16,
		// Token: 0x040003EC RID: 1004
		LogonServer,
		// Token: 0x040003ED RID: 1005
		DifferenceAtDc,
		// Token: 0x040003EE RID: 1006
		SynchronizationRequired,
		// Token: 0x040003EF RID: 1007
		DllNotFound,
		// Token: 0x040003F0 RID: 1008
		IoPrivilegeFailed = 3221225783U,
		// Token: 0x040003F1 RID: 1009
		OrdinalNotFound,
		// Token: 0x040003F2 RID: 1010
		EntryPointNotFound,
		// Token: 0x040003F3 RID: 1011
		ControlCExit,
		// Token: 0x040003F4 RID: 1012
		PortNotSet = 3221226323U,
		// Token: 0x040003F5 RID: 1013
		DebuggerInactive,
		// Token: 0x040003F6 RID: 1014
		CallbackBypass = 3221226755U,
		// Token: 0x040003F7 RID: 1015
		PortClosed = 3221227264U,
		// Token: 0x040003F8 RID: 1016
		MessageLost,
		// Token: 0x040003F9 RID: 1017
		InvalidMessage,
		// Token: 0x040003FA RID: 1018
		RequestCanceled,
		// Token: 0x040003FB RID: 1019
		RecursiveDispatch,
		// Token: 0x040003FC RID: 1020
		LpcReceiveBufferExpected,
		// Token: 0x040003FD RID: 1021
		LpcInvalidConnectionUsage,
		// Token: 0x040003FE RID: 1022
		LpcRequestsNotAllowed,
		// Token: 0x040003FF RID: 1023
		ResourceInUse,
		// Token: 0x04000400 RID: 1024
		ProcessIsProtected = 3221227282U,
		// Token: 0x04000401 RID: 1025
		VolumeDirty = 3221227526U,
		// Token: 0x04000402 RID: 1026
		FileCheckedOut = 3221227777U,
		// Token: 0x04000403 RID: 1027
		CheckOutRequired,
		// Token: 0x04000404 RID: 1028
		BadFileType,
		// Token: 0x04000405 RID: 1029
		FileTooLarge,
		// Token: 0x04000406 RID: 1030
		FormsAuthRequired,
		// Token: 0x04000407 RID: 1031
		VirusInfected,
		// Token: 0x04000408 RID: 1032
		VirusDeleted,
		// Token: 0x04000409 RID: 1033
		TransactionalConflict = 3222863873U,
		// Token: 0x0400040A RID: 1034
		InvalidTransaction,
		// Token: 0x0400040B RID: 1035
		TransactionNotActive,
		// Token: 0x0400040C RID: 1036
		TmInitializationFailed,
		// Token: 0x0400040D RID: 1037
		RmNotActive,
		// Token: 0x0400040E RID: 1038
		RmMetadataCorrupt,
		// Token: 0x0400040F RID: 1039
		TransactionNotJoined,
		// Token: 0x04000410 RID: 1040
		DirectoryNotRm,
		// Token: 0x04000411 RID: 1041
		CouldNotResizeLog,
		// Token: 0x04000412 RID: 1042
		TransactionsUnsupportedRemote,
		// Token: 0x04000413 RID: 1043
		LogResizeInvalidSize,
		// Token: 0x04000414 RID: 1044
		RemoteFileVersionMismatch,
		// Token: 0x04000415 RID: 1045
		CrmProtocolAlreadyExists = 3222863887U,
		// Token: 0x04000416 RID: 1046
		TransactionPropagationFailed,
		// Token: 0x04000417 RID: 1047
		CrmProtocolNotFound,
		// Token: 0x04000418 RID: 1048
		TransactionSuperiorExists,
		// Token: 0x04000419 RID: 1049
		TransactionRequestNotValid,
		// Token: 0x0400041A RID: 1050
		TransactionNotRequested,
		// Token: 0x0400041B RID: 1051
		TransactionAlreadyAborted,
		// Token: 0x0400041C RID: 1052
		TransactionAlreadyCommitted,
		// Token: 0x0400041D RID: 1053
		TransactionInvalidMarshallBuffer,
		// Token: 0x0400041E RID: 1054
		CurrentTransactionNotValid,
		// Token: 0x0400041F RID: 1055
		LogGrowthFailed,
		// Token: 0x04000420 RID: 1056
		ObjectNoLongerExists = 3222863905U,
		// Token: 0x04000421 RID: 1057
		StreamMiniversionNotFound,
		// Token: 0x04000422 RID: 1058
		StreamMiniversionNotValid,
		// Token: 0x04000423 RID: 1059
		MiniversionInaccessibleFromSpecifiedTransaction,
		// Token: 0x04000424 RID: 1060
		CantOpenMiniversionWithModifyIntent,
		// Token: 0x04000425 RID: 1061
		CantCreateMoreStreamMiniversions,
		// Token: 0x04000426 RID: 1062
		HandleNoLongerValid = 3222863912U,
		// Token: 0x04000427 RID: 1063
		NoTxfMetadata,
		// Token: 0x04000428 RID: 1064
		LogCorruptionDetected = 3222863920U,
		// Token: 0x04000429 RID: 1065
		CantRecoverWithHandleOpen,
		// Token: 0x0400042A RID: 1066
		RmDisconnected,
		// Token: 0x0400042B RID: 1067
		EnlistmentNotSuperior,
		// Token: 0x0400042C RID: 1068
		RecoveryNotNeeded,
		// Token: 0x0400042D RID: 1069
		RmAlreadyStarted,
		// Token: 0x0400042E RID: 1070
		FileIdentityNotPersistent,
		// Token: 0x0400042F RID: 1071
		CantBreakTransactionalDependency,
		// Token: 0x04000430 RID: 1072
		CantCrossRmBoundary,
		// Token: 0x04000431 RID: 1073
		TxfDirNotEmpty,
		// Token: 0x04000432 RID: 1074
		IndoubtTransactionsExist,
		// Token: 0x04000433 RID: 1075
		TmVolatile,
		// Token: 0x04000434 RID: 1076
		RollbackTimerExpired,
		// Token: 0x04000435 RID: 1077
		TxfAttributeCorrupt,
		// Token: 0x04000436 RID: 1078
		EfsNotAllowedInTransaction,
		// Token: 0x04000437 RID: 1079
		TransactionalOpenNotAllowed,
		// Token: 0x04000438 RID: 1080
		TransactedMappingUnsupportedRemote,
		// Token: 0x04000439 RID: 1081
		TxfMetadataAlreadyPresent,
		// Token: 0x0400043A RID: 1082
		TransactionScopeCallbacksNotSet,
		// Token: 0x0400043B RID: 1083
		TransactionRequiredPromotion,
		// Token: 0x0400043C RID: 1084
		CannotExecuteFileInTransaction,
		// Token: 0x0400043D RID: 1085
		TransactionsNotFrozen,
		// Token: 0x0400043E RID: 1086
		MaximumNtStatus = 4294967295U
	}
}
