using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000553 RID: 1363
	[System.Serializable]
	public class ColorSmoother : Il2CppSystem.Object
	{
		// Token: 0x06007875 RID: 30837 RVA: 0x0020DCFC File Offset: 0x0020BEFC
		// Note: this type is marked as 'beforefieldinit'.
		static ColorSmoother()
		{
			Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "ColorSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr);
			ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			ColorSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "DefaultValue");
			ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "SmoothingSpeed");
			ColorSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "overrides");
			ColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678557);
			ColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678558);
			ColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678559);
			ColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678560);
			ColorSmoother.NativeMethodInfoPtr_get_Default_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678561);
			ColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678562);
			ColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678563);
			ColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678564);
			ColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678565);
			ColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678566);
			ColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678567);
			ColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678568);
			ColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, 100678569);
		}

		// Token: 0x17002449 RID: 9289
		// (get) Token: 0x06007876 RID: 30838 RVA: 0x0020DE94 File Offset: 0x0020C094
		// (set) Token: 0x06007877 RID: 30839 RVA: 0x0020DED0 File Offset: 0x0020C0D0
		public unsafe Color CurrentValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31395, RefRangeEnd = 31396, XrefRangeStart = 31395, XrefRangeEnd = 31396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700244A RID: 9290
		// (get) Token: 0x06007878 RID: 30840 RVA: 0x0020DF10 File Offset: 0x0020C110
		// (set) Token: 0x06007879 RID: 30841 RVA: 0x0020DF4C File Offset: 0x0020C14C
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700244B RID: 9291
		// (get) Token: 0x0600787A RID: 30842 RVA: 0x0020DF8C File Offset: 0x0020C18C
		public unsafe Color Default
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_get_Default_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x0020DFC8 File Offset: 0x0020C1C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234558, RefRangeEnd = 234559, XrefRangeStart = 234537, XrefRangeEnd = 234558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x0020DFFC File Offset: 0x0020C1FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234559, XrefRangeEnd = 234577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x0020E030 File Offset: 0x0020C230
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 234580, RefRangeEnd = 234581, XrefRangeStart = 234577, XrefRangeEnd = 234580, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x0020E070 File Offset: 0x0020C270
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x0020E0B0 File Offset: 0x0020C2B0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 234625, RefRangeEnd = 234630, XrefRangeStart = 234581, XrefRangeEnd = 234625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(Color value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x0020E110 File Offset: 0x0020C310
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 234666, RefRangeEnd = 234668, XrefRangeStart = 234630, XrefRangeEnd = 234666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x0020E154 File Offset: 0x0020C354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234668, XrefRangeEnd = 234674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x0020E188 File Offset: 0x0020C388
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234674, XrefRangeEnd = 234682, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x00038D5D File Offset: 0x00036F5D
		public ColorSmoother(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x06007884 RID: 30852 RVA: 0x0020E1C4 File Offset: 0x0020C3C4
		// (set) Token: 0x06007885 RID: 30853 RVA: 0x00038D66 File Offset: 0x00036F66
		public unsafe Color _CurrentValue_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x06007886 RID: 30854 RVA: 0x0020E1EC File Offset: 0x0020C3EC
		// (set) Token: 0x06007887 RID: 30855 RVA: 0x00038D81 File Offset: 0x00036F81
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x17002446 RID: 9286
		// (get) Token: 0x06007888 RID: 30856 RVA: 0x0020E214 File Offset: 0x0020C414
		// (set) Token: 0x06007889 RID: 30857 RVA: 0x00038D9C File Offset: 0x00036F9C
		public unsafe Color DefaultValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x17002447 RID: 9287
		// (get) Token: 0x0600788A RID: 30858 RVA: 0x0020E23C File Offset: 0x0020C43C
		// (set) Token: 0x0600788B RID: 30859 RVA: 0x00038DB7 File Offset: 0x00036FB7
		public unsafe float SmoothingSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x17002448 RID: 9288
		// (get) Token: 0x0600788C RID: 30860 RVA: 0x0020E264 File Offset: 0x0020C464
		// (set) Token: 0x0600788D RID: 30861 RVA: 0x00038DD2 File Offset: 0x00036FD2
		public unsafe List<ColorSmoother.Override> overrides
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_overrides);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ColorSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400524A RID: 21066
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x0400524B RID: 21067
		private static readonly System.IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x0400524C RID: 21068
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x0400524D RID: 21069
		private static readonly System.IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x0400524E RID: 21070
		private static readonly System.IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x0400524F RID: 21071
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0;

		// Token: 0x04005250 RID: 21072
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0;

		// Token: 0x04005251 RID: 21073
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x04005252 RID: 21074
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x04005253 RID: 21075
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_get_Color_0;

		// Token: 0x04005254 RID: 21076
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x04005255 RID: 21077
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x04005256 RID: 21078
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Color_0;

		// Token: 0x04005257 RID: 21079
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x04005258 RID: 21080
		private static readonly System.IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0;

		// Token: 0x04005259 RID: 21081
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x0400525A RID: 21082
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x0400525B RID: 21083
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AE5 RID: 2789
		[System.Serializable]
		public class Override : Il2CppSystem.Object
		{
			// Token: 0x0600D7E6 RID: 55270 RVA: 0x0033C1F0 File Offset: 0x0033A3F0
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr);
				ColorSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Value");
				ColorSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Priority");
				ColorSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, "Label");
				ColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr, 100678570);
			}

			// Token: 0x0600D7E7 RID: 55271 RVA: 0x0033C26C File Offset: 0x0033A46C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.Override>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7E8 RID: 55272 RVA: 0x00068C6B File Offset: 0x00066E6B
			public Override(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042AA RID: 17066
			// (get) Token: 0x0600D7E9 RID: 55273 RVA: 0x0033C2A8 File Offset: 0x0033A4A8
			// (set) Token: 0x0600D7EA RID: 55274 RVA: 0x00068C74 File Offset: 0x00066E74
			public unsafe Color Value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170042AB RID: 17067
			// (get) Token: 0x0600D7EB RID: 55275 RVA: 0x0033C2D0 File Offset: 0x0033A4D0
			// (set) Token: 0x0600D7EC RID: 55276 RVA: 0x00068C8F File Offset: 0x00066E8F
			public unsafe int Priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x170042AC RID: 17068
			// (get) Token: 0x0600D7ED RID: 55277 RVA: 0x0033C2F8 File Offset: 0x0033A4F8
			// (set) Token: 0x0600D7EE RID: 55278 RVA: 0x00068CAA File Offset: 0x00066EAA
			public unsafe string Label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009197 RID: 37271
			private static readonly System.IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x04009198 RID: 37272
			private static readonly System.IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x04009199 RID: 37273
			private static readonly System.IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x0400919A RID: 37274
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AE6 RID: 2790
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D7EF RID: 55279 RVA: 0x0033C320 File Offset: 0x0033A520
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr);
				ColorSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9");
				ColorSmoother.__c.NativeFieldInfoPtr___9__18_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9__18_1");
				ColorSmoother.__c.NativeFieldInfoPtr___9__19_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, "<>9__19_1");
				ColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678572);
				ColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678573);
				ColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr, 100678574);
			}

			// Token: 0x0600D7F0 RID: 55280 RVA: 0x0033C3C4 File Offset: 0x0033A5C4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7F1 RID: 55281 RVA: 0x0033C400 File Offset: 0x0033A600
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 234535, XrefRangeEnd = 234537, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__18_1(ColorSmoother.Override x, ColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D7F2 RID: 55282 RVA: 0x0033C460 File Offset: 0x0033A660
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__19_1(ColorSmoother.Override x, ColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D7F3 RID: 55283 RVA: 0x00068CC9 File Offset: 0x00066EC9
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042AD RID: 17069
			// (get) Token: 0x0600D7F4 RID: 55284 RVA: 0x0033C4C0 File Offset: 0x0033A6C0
			// (set) Token: 0x0600D7F5 RID: 55285 RVA: 0x00068CD2 File Offset: 0x00066ED2
			public unsafe static ColorSmoother.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AE RID: 17070
			// (get) Token: 0x0600D7F6 RID: 55286 RVA: 0x0033C4E8 File Offset: 0x0033A6E8
			// (set) Token: 0x0600D7F7 RID: 55287 RVA: 0x00068CE4 File Offset: 0x00066EE4
			public unsafe static Il2CppSystem.Comparison<ColorSmoother.Override> __9__18_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9__18_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9__18_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042AF RID: 17071
			// (get) Token: 0x0600D7F8 RID: 55288 RVA: 0x0033C510 File Offset: 0x0033A710
			// (set) Token: 0x0600D7F9 RID: 55289 RVA: 0x00068CF6 File Offset: 0x00066EF6
			public unsafe static Il2CppSystem.Comparison<ColorSmoother.Override> __9__19_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ColorSmoother.__c.NativeFieldInfoPtr___9__19_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<ColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ColorSmoother.__c.NativeFieldInfoPtr___9__19_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400919B RID: 37275
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400919C RID: 37276
			private static readonly System.IntPtr NativeFieldInfoPtr___9__18_1;

			// Token: 0x0400919D RID: 37277
			private static readonly System.IntPtr NativeFieldInfoPtr___9__19_1;

			// Token: 0x0400919E RID: 37278
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400919F RID: 37279
			private static readonly System.IntPtr NativeMethodInfoPtr__AddOverride_b__18_1_Internal_Int32_Override_Override_0;

			// Token: 0x040091A0 RID: 37280
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOverride_b__19_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000AE7 RID: 2791
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7FA RID: 55290 RVA: 0x0033C538 File Offset: 0x0033A738
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr);
				ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, "label");
				ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678575);
				ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr, 100678576);
			}

			// Token: 0x0600D7FB RID: 55291 RVA: 0x0033C5A0 File Offset: 0x0033A7A0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7FC RID: 55292 RVA: 0x0033C5DC File Offset: 0x0033A7DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(ColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass18_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D7FD RID: 55293 RVA: 0x00068D08 File Offset: 0x00066F08
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B0 RID: 17072
			// (get) Token: 0x0600D7FE RID: 55294 RVA: 0x0033C62C File Offset: 0x0033A82C
			// (set) Token: 0x0600D7FF RID: 55295 RVA: 0x00068D11 File Offset: 0x00066F11
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass18_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091A1 RID: 37281
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040091A2 RID: 37282
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091A3 RID: 37283
			private static readonly System.IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000AE8 RID: 2792
		[ObfuscatedName("ScheduleOne.Tools.ColorSmoother+<>c__DisplayClass19_0")]
		public sealed class __c__DisplayClass19_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D800 RID: 55296 RVA: 0x0033C654 File Offset: 0x0033A854
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass19_0()
			{
				Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColorSmoother>.NativeClassPtr, "<>c__DisplayClass19_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr);
				ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, "label");
				ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, 100678577);
				ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr, 100678578);
			}

			// Token: 0x0600D801 RID: 55297 RVA: 0x0033C6BC File Offset: 0x0033A8BC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass19_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorSmoother.__c__DisplayClass19_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D802 RID: 55298 RVA: 0x0033C6F8 File Offset: 0x0033A8F8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(ColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ColorSmoother.__c__DisplayClass19_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D803 RID: 55299 RVA: 0x00068D30 File Offset: 0x00066F30
			public __c__DisplayClass19_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042B1 RID: 17073
			// (get) Token: 0x0600D804 RID: 55300 RVA: 0x0033C748 File Offset: 0x0033A948
			// (set) Token: 0x0600D805 RID: 55301 RVA: 0x00068D39 File Offset: 0x00066F39
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ColorSmoother.__c__DisplayClass19_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091A4 RID: 37284
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040091A5 RID: 37285
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091A6 RID: 37286
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
