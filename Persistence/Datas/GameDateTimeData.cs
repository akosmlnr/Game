using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.GameTime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000279 RID: 633
	[Serializable]
	public class GameDateTimeData : SaveData
	{
		// Token: 0x06003037 RID: 12343 RVA: 0x0010DD3C File Offset: 0x0010BF3C
		// Note: this type is marked as 'beforefieldinit'.
		static GameDateTimeData()
		{
			Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GameDateTimeData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr);
			GameDateTimeData.NativeFieldInfoPtr_ElapsedDays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, "ElapsedDays");
			GameDateTimeData.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, "Time");
			GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, 100668976);
			GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr, 100668977);
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0010DDBC File Offset: 0x0010BFBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 136492, XrefRangeEnd = 136493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTimeData(int _elapsedDays, int _time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref _elapsedDays;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _time;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0010DE14 File Offset: 0x0010C014
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 136494, RefRangeEnd = 136498, XrefRangeStart = 136493, XrefRangeEnd = 136494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameDateTimeData(GameDateTime gameDateTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameDateTimeData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref gameDateTime;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameDateTimeData.NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x000193C9 File Offset: 0x000175C9
		public GameDateTimeData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x0600303B RID: 12347 RVA: 0x0010DE5C File Offset: 0x0010C05C
		// (set) Token: 0x0600303C RID: 12348 RVA: 0x000193D2 File Offset: 0x000175D2
		public unsafe int ElapsedDays
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_ElapsedDays);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_ElapsedDays)) = value;
			}
		}

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x0600303D RID: 12349 RVA: 0x0010DE84 File Offset: 0x0010C084
		// (set) Token: 0x0600303E RID: 12350 RVA: 0x000193ED File Offset: 0x000175ED
		public unsafe int Time
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_Time);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GameDateTimeData.NativeFieldInfoPtr_Time)) = value;
			}
		}

		// Token: 0x04001FE3 RID: 8163
		private static readonly IntPtr NativeFieldInfoPtr_ElapsedDays;

		// Token: 0x04001FE4 RID: 8164
		private static readonly IntPtr NativeFieldInfoPtr_Time;

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GameDateTime_0;
	}
}
