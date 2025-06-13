using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Quests
{
	// Token: 0x020001D4 RID: 468
	[System.Serializable]
	public class QuestWindowConfig : Il2CppSystem.Object
	{
		// Token: 0x06002774 RID: 10100 RVA: 0x000EF298 File Offset: 0x000ED498
		// Note: this type is marked as 'beforefieldinit'.
		static QuestWindowConfig()
		{
			Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Quests", "QuestWindowConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr);
			QuestWindowConfig.NativeFieldInfoPtr_IsEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "IsEnabled");
			QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "WindowStartTime");
			QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, "WindowEndTime");
			QuestWindowConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr, 100667742);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000EF318 File Offset: 0x000ED518
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 120995, RefRangeEnd = 121001, XrefRangeStart = 120994, XrefRangeEnd = 120995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe QuestWindowConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<QuestWindowConfig>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(QuestWindowConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00015BF8 File Offset: 0x00013DF8
		public QuestWindowConfig(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000EF354 File Offset: 0x000ED554
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x00015C01 File Offset: 0x00013E01
		public unsafe bool IsEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_IsEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_IsEnabled)) = value;
			}
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x000EF37C File Offset: 0x000ED57C
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x00015C1C File Offset: 0x00013E1C
		public unsafe int WindowStartTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowStartTime)) = value;
			}
		}

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x0600277B RID: 10107 RVA: 0x000EF3A4 File Offset: 0x000ED5A4
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x00015C37 File Offset: 0x00013E37
		public unsafe int WindowEndTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(QuestWindowConfig.NativeFieldInfoPtr_WindowEndTime)) = value;
			}
		}

		// Token: 0x04001A38 RID: 6712
		private static readonly System.IntPtr NativeFieldInfoPtr_IsEnabled;

		// Token: 0x04001A39 RID: 6713
		private static readonly System.IntPtr NativeFieldInfoPtr_WindowStartTime;

		// Token: 0x04001A3A RID: 6714
		private static readonly System.IntPtr NativeFieldInfoPtr_WindowEndTime;

		// Token: 0x04001A3B RID: 6715
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
