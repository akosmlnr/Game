using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200019C RID: 412
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct GameDateTime
	{
		// Token: 0x06002126 RID: 8486 RVA: 0x000DA838 File Offset: 0x000D8A38
		// Note: this type is marked as 'beforefieldinit'.
		static GameDateTime()
		{
			Il2CppClassPointerStore<GameDateTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "GameDateTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr);
			GameDateTime.NativeFieldInfoPtr_elapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, "elapsedDays");
			GameDateTime.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, "time");
			GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667030);
			GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667031);
			GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_GameDateTimeData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667032);
			GameDateTime.NativeMethodInfoPtr_GetMinSum_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667033);
			GameDateTime.NativeMethodInfoPtr_AddMins_Public_GameDateTime_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667034);
			GameDateTime.NativeMethodInfoPtr_op_Addition_Public_Static_GameDateTime_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667035);
			GameDateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_GameDateTime_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667036);
			GameDateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667037);
			GameDateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameDateTime_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, 100667038);
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x000DA944 File Offset: 0x000D8B44
		[CallerCount(486)]
		[CachedScanResults(RefRangeStart = 35745, RefRangeEnd = 36231, XrefRangeStart = 35745, XrefRangeEnd = 36231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime(int _elapsedDays, int _time)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _elapsedDays;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref _time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x000DA984 File Offset: 0x000D8B84
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 112748, RefRangeEnd = 112751, XrefRangeStart = 112748, XrefRangeEnd = 112748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime(int _minSum)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref _minSum;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x000DA9B8 File Offset: 0x000D8BB8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112751, RefRangeEnd = 112755, XrefRangeStart = 112751, XrefRangeEnd = 112751, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime(GameDateTimeData data)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr__ctor_Public_Void_GameDateTimeData_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600212A RID: 8490 RVA: 0x000DA9F0 File Offset: 0x000D8BF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 112755, RefRangeEnd = 112759, XrefRangeStart = 112755, XrefRangeEnd = 112755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetMinSum()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_GetMinSum_Public_Int32_0, ref this, (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600212B RID: 8491 RVA: 0x000DAA20 File Offset: 0x000D8C20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112759, XrefRangeEnd = 112760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTime AddMins(int mins)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref mins;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_AddMins_Public_GameDateTime_Int32_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600212C RID: 8492 RVA: 0x000DAA60 File Offset: 0x000D8C60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112760, XrefRangeEnd = 112761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDateTime operator +(GameDateTime a, GameDateTime b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_Addition_Public_Static_GameDateTime_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600212D RID: 8493 RVA: 0x000DAAAC File Offset: 0x000D8CAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 112761, XrefRangeEnd = 112762, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static GameDateTime operator -(GameDateTime a, GameDateTime b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_Subtraction_Public_Static_GameDateTime_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600212E RID: 8494 RVA: 0x000DAAF8 File Offset: 0x000D8CF8
		[CallerCount(0)]
		public unsafe static bool operator >(GameDateTime a, GameDateTime b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600212F RID: 8495 RVA: 0x000DAB44 File Offset: 0x000D8D44
		[CallerCount(0)]
		public unsafe static bool operator <(GameDateTime a, GameDateTime b)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref a;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref b;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameDateTime.NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameDateTime_GameDateTime_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06002130 RID: 8496 RVA: 0x000128EB File Offset: 0x00010AEB
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GameDateTime>.NativeClassPtr, ref this));
		}

		// Token: 0x040015F5 RID: 5621
		private static readonly System.IntPtr NativeFieldInfoPtr_elapsedDays;

		// Token: 0x040015F6 RID: 5622
		private static readonly System.IntPtr NativeFieldInfoPtr_time;

		// Token: 0x040015F7 RID: 5623
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x040015F8 RID: 5624
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040015F9 RID: 5625
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameDateTimeData_0;

		// Token: 0x040015FA RID: 5626
		private static readonly System.IntPtr NativeMethodInfoPtr_GetMinSum_Public_Int32_0;

		// Token: 0x040015FB RID: 5627
		private static readonly System.IntPtr NativeMethodInfoPtr_AddMins_Public_GameDateTime_Int32_0;

		// Token: 0x040015FC RID: 5628
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_GameDateTime_GameDateTime_GameDateTime_0;

		// Token: 0x040015FD RID: 5629
		private static readonly System.IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_GameDateTime_GameDateTime_GameDateTime_0;

		// Token: 0x040015FE RID: 5630
		private static readonly System.IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x040015FF RID: 5631
		private static readonly System.IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_Boolean_GameDateTime_GameDateTime_0;

		// Token: 0x04001600 RID: 5632
		[FieldOffset(0)]
		public int elapsedDays;

		// Token: 0x04001601 RID: 5633
		[FieldOffset(4)]
		public int time;
	}
}
