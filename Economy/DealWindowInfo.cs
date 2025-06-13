using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Economy
{
	// Token: 0x02000436 RID: 1078
	[StructLayout(LayoutKind.Explicit)]
	public struct DealWindowInfo
	{
		// Token: 0x06005D65 RID: 23909 RVA: 0x001B2EE4 File Offset: 0x001B10E4
		// Note: this type is marked as 'beforefieldinit'.
		static DealWindowInfo()
		{
			Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Economy", "DealWindowInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr);
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_DURATION_MINS");
			DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "WINDOW_COUNT");
			DealWindowInfo.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "StartTime");
			DealWindowInfo.NativeFieldInfoPtr_EndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "EndTime");
			DealWindowInfo.NativeFieldInfoPtr_Morning = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Morning");
			DealWindowInfo.NativeFieldInfoPtr_Afternoon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Afternoon");
			DealWindowInfo.NativeFieldInfoPtr_Night = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "Night");
			DealWindowInfo.NativeFieldInfoPtr_LateNight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, "LateNight");
			DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100675297);
			DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100675298);
			DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, 100675299);
		}

		// Token: 0x06005D66 RID: 23910 RVA: 0x001B2FF0 File Offset: 0x001B11F0
		[CallerCount(486)]
		[CachedScanResults(RefRangeStart = 35745, RefRangeEnd = 36231, XrefRangeStart = 35745, XrefRangeEnd = 36231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealWindowInfo(int startTime, int endTime)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startTime;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endTime;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005D67 RID: 23911 RVA: 0x001B3030 File Offset: 0x001B1230
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 197779, RefRangeEnd = 197782, XrefRangeStart = 197775, XrefRangeEnd = 197779, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DealWindowInfo GetWindowInfo(EDealWindow window)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref window;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005D68 RID: 23912 RVA: 0x001B3070 File Offset: 0x001B1270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 197788, RefRangeEnd = 197790, XrefRangeStart = 197782, XrefRangeEnd = 197788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EDealWindow GetWindow(int time)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref time;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealWindowInfo.NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005D69 RID: 23913 RVA: 0x0002BD58 File Offset: 0x00029F58
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealWindowInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06005D6A RID: 23914 RVA: 0x001B30B0 File Offset: 0x001B12B0
		// (set) Token: 0x06005D6B RID: 23915 RVA: 0x0002BD6A File Offset: 0x00029F6A
		public unsafe static int WINDOW_DURATION_MINS
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_DURATION_MINS, (void*)(&value));
			}
		}

		// Token: 0x17001BEB RID: 7147
		// (get) Token: 0x06005D6C RID: 23916 RVA: 0x001B30CC File Offset: 0x001B12CC
		// (set) Token: 0x06005D6D RID: 23917 RVA: 0x0002BD78 File Offset: 0x00029F78
		public unsafe static int WINDOW_COUNT
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_WINDOW_COUNT, (void*)(&value));
			}
		}

		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06005D6E RID: 23918 RVA: 0x001B30E8 File Offset: 0x001B12E8
		// (set) Token: 0x06005D6F RID: 23919 RVA: 0x0002BD86 File Offset: 0x00029F86
		public unsafe static DealWindowInfo Morning
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Morning, (void*)(&value));
			}
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06005D70 RID: 23920 RVA: 0x001B3104 File Offset: 0x001B1304
		// (set) Token: 0x06005D71 RID: 23921 RVA: 0x0002BD94 File Offset: 0x00029F94
		public unsafe static DealWindowInfo Afternoon
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Afternoon, (void*)(&value));
			}
		}

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06005D72 RID: 23922 RVA: 0x001B3120 File Offset: 0x001B1320
		// (set) Token: 0x06005D73 RID: 23923 RVA: 0x0002BDA2 File Offset: 0x00029FA2
		public unsafe static DealWindowInfo Night
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_Night, (void*)(&value));
			}
		}

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06005D74 RID: 23924 RVA: 0x001B313C File Offset: 0x001B133C
		// (set) Token: 0x06005D75 RID: 23925 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		public unsafe static DealWindowInfo LateNight
		{
			get
			{
				DealWindowInfo result;
				IL2CPP.il2cpp_field_static_get_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DealWindowInfo.NativeFieldInfoPtr_LateNight, (void*)(&value));
			}
		}

		// Token: 0x04003FDC RID: 16348
		private static readonly System.IntPtr NativeFieldInfoPtr_WINDOW_DURATION_MINS;

		// Token: 0x04003FDD RID: 16349
		private static readonly System.IntPtr NativeFieldInfoPtr_WINDOW_COUNT;

		// Token: 0x04003FDE RID: 16350
		private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;

		// Token: 0x04003FDF RID: 16351
		private static readonly System.IntPtr NativeFieldInfoPtr_EndTime;

		// Token: 0x04003FE0 RID: 16352
		private static readonly System.IntPtr NativeFieldInfoPtr_Morning;

		// Token: 0x04003FE1 RID: 16353
		private static readonly System.IntPtr NativeFieldInfoPtr_Afternoon;

		// Token: 0x04003FE2 RID: 16354
		private static readonly System.IntPtr NativeFieldInfoPtr_Night;

		// Token: 0x04003FE3 RID: 16355
		private static readonly System.IntPtr NativeFieldInfoPtr_LateNight;

		// Token: 0x04003FE4 RID: 16356
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04003FE5 RID: 16357
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWindowInfo_Public_Static_DealWindowInfo_EDealWindow_0;

		// Token: 0x04003FE6 RID: 16358
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWindow_Public_Static_EDealWindow_Int32_0;

		// Token: 0x04003FE7 RID: 16359
		[FieldOffset(0)]
		public int StartTime;

		// Token: 0x04003FE8 RID: 16360
		[FieldOffset(4)]
		public int EndTime;
	}
}
