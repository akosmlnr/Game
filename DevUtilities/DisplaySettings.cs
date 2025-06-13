using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000493 RID: 1171
	[System.Serializable]
	[StructLayout(LayoutKind.Explicit)]
	public struct DisplaySettings
	{
		// Token: 0x0600644A RID: 25674 RVA: 0x001C9CE4 File Offset: 0x001C7EE4
		// Note: this type is marked as 'beforefieldinit'.
		static DisplaySettings()
		{
			Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "DisplaySettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr);
			DisplaySettings.NativeFieldInfoPtr_ResolutionIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ResolutionIndex");
			DisplaySettings.NativeFieldInfoPtr_DisplayMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "DisplayMode");
			DisplaySettings.NativeFieldInfoPtr_VSync = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "VSync");
			DisplaySettings.NativeFieldInfoPtr_TargetFPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "TargetFPS");
			DisplaySettings.NativeFieldInfoPtr_UIScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "UIScale");
			DisplaySettings.NativeFieldInfoPtr_CameraBobbing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "CameraBobbing");
			DisplaySettings.NativeFieldInfoPtr_ActiveDisplayIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "ActiveDisplayIndex");
			DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, 100676111);
		}

		// Token: 0x0600644B RID: 25675 RVA: 0x001C9DB4 File Offset: 0x001C7FB4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 206591, RefRangeEnd = 206593, XrefRangeStart = 206561, XrefRangeEnd = 206591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static List<Resolution> GetResolutions()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Resolution>>(intPtr2) : null;
		}

		// Token: 0x0600644C RID: 25676 RVA: 0x0002F2B9 File Offset: 0x0002D4B9
		public Il2CppSystem.Object BoxIl2CppObject()
		{
			return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, ref this));
		}

		// Token: 0x04004460 RID: 17504
		private static readonly System.IntPtr NativeFieldInfoPtr_ResolutionIndex;

		// Token: 0x04004461 RID: 17505
		private static readonly System.IntPtr NativeFieldInfoPtr_DisplayMode;

		// Token: 0x04004462 RID: 17506
		private static readonly System.IntPtr NativeFieldInfoPtr_VSync;

		// Token: 0x04004463 RID: 17507
		private static readonly System.IntPtr NativeFieldInfoPtr_TargetFPS;

		// Token: 0x04004464 RID: 17508
		private static readonly System.IntPtr NativeFieldInfoPtr_UIScale;

		// Token: 0x04004465 RID: 17509
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraBobbing;

		// Token: 0x04004466 RID: 17510
		private static readonly System.IntPtr NativeFieldInfoPtr_ActiveDisplayIndex;

		// Token: 0x04004467 RID: 17511
		private static readonly System.IntPtr NativeMethodInfoPtr_GetResolutions_Public_Static_List_1_Resolution_0;

		// Token: 0x04004468 RID: 17512
		[FieldOffset(0)]
		public int ResolutionIndex;

		// Token: 0x04004469 RID: 17513
		[FieldOffset(4)]
		public DisplaySettings.EDisplayMode DisplayMode;

		// Token: 0x0400446A RID: 17514
		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.U1)]
		public bool VSync;

		// Token: 0x0400446B RID: 17515
		[FieldOffset(12)]
		public int TargetFPS;

		// Token: 0x0400446C RID: 17516
		[FieldOffset(16)]
		public float UIScale;

		// Token: 0x0400446D RID: 17517
		[FieldOffset(20)]
		public float CameraBobbing;

		// Token: 0x0400446E RID: 17518
		[FieldOffset(24)]
		public int ActiveDisplayIndex;

		// Token: 0x02000A68 RID: 2664
		[OriginalName("Assembly-CSharp.dll", "", "EDisplayMode")]
		public enum EDisplayMode
		{
			// Token: 0x04008F2A RID: 36650
			Windowed,
			// Token: 0x04008F2B RID: 36651
			FullscreenWindow,
			// Token: 0x04008F2C RID: 36652
			ExclusiveFullscreen
		}

		// Token: 0x02000A69 RID: 2665
		[ObfuscatedName("ScheduleOne.DevUtilities.DisplaySettings+<>c__DisplayClass8_0")]
		public sealed class __c__DisplayClass8_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D429 RID: 54313 RVA: 0x00331E40 File Offset: 0x00330040
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass8_0()
			{
				Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DisplaySettings>.NativeClassPtr, "<>c__DisplayClass8_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr);
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "resolutions");
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "i");
				DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, "<>9__0");
				DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, 100676112);
				DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr, 100676113);
			}

			// Token: 0x0600D42A RID: 54314 RVA: 0x00331ED0 File Offset: 0x003300D0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass8_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisplaySettings.__c__DisplayClass8_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D42B RID: 54315 RVA: 0x00331F0C File Offset: 0x0033010C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 206559, XrefRangeEnd = 206561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetResolutions_b__0(Resolution x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref x;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DisplaySettings.__c__DisplayClass8_0.NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D42C RID: 54316 RVA: 0x00066DF0 File Offset: 0x00064FF0
			public __c__DisplayClass8_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041A9 RID: 16809
			// (get) Token: 0x0600D42D RID: 54317 RVA: 0x00331F58 File Offset: 0x00330158
			// (set) Token: 0x0600D42E RID: 54318 RVA: 0x00066DF9 File Offset: 0x00064FF9
			public unsafe Il2CppStructArray<Resolution> resolutions
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<Resolution>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_resolutions), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041AA RID: 16810
			// (get) Token: 0x0600D42F RID: 54319 RVA: 0x00331F88 File Offset: 0x00330188
			// (set) Token: 0x0600D430 RID: 54320 RVA: 0x00066E18 File Offset: 0x00065018
			public unsafe int i
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr_i)) = value;
				}
			}

			// Token: 0x170041AB RID: 16811
			// (get) Token: 0x0600D431 RID: 54321 RVA: 0x00331FB0 File Offset: 0x003301B0
			// (set) Token: 0x0600D432 RID: 54322 RVA: 0x00066E33 File Offset: 0x00065033
			public unsafe Il2CppSystem.Predicate<Resolution> __9__0
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Predicate<Resolution>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DisplaySettings.__c__DisplayClass8_0.NativeFieldInfoPtr___9__0), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F2D RID: 36653
			private static readonly System.IntPtr NativeFieldInfoPtr_resolutions;

			// Token: 0x04008F2E RID: 36654
			private static readonly System.IntPtr NativeFieldInfoPtr_i;

			// Token: 0x04008F2F RID: 36655
			private static readonly System.IntPtr NativeFieldInfoPtr___9__0;

			// Token: 0x04008F30 RID: 36656
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F31 RID: 36657
			private static readonly System.IntPtr NativeMethodInfoPtr__GetResolutions_b__0_Internal_Boolean_Resolution_0;
		}
	}
}
