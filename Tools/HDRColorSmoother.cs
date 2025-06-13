using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x0200055F RID: 1375
	[System.Serializable]
	public class HDRColorSmoother : Il2CppSystem.Object
	{
		// Token: 0x06007905 RID: 30981 RVA: 0x0020F874 File Offset: 0x0020DA74
		// Note: this type is marked as 'beforefieldinit'.
		static HDRColorSmoother()
		{
			Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "HDRColorSmoother");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr);
			HDRColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<CurrentValue>k__BackingField");
			HDRColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<Multiplier>k__BackingField");
			HDRColorSmoother.NativeFieldInfoPtr_DefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "DefaultValue");
			HDRColorSmoother.NativeFieldInfoPtr_SmoothingSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "SmoothingSpeed");
			HDRColorSmoother.NativeFieldInfoPtr_overrides = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "overrides");
			HDRColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678637);
			HDRColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678638);
			HDRColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678639);
			HDRColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678640);
			HDRColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678641);
			HDRColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678642);
			HDRColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678643);
			HDRColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678644);
			HDRColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678645);
			HDRColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678646);
			HDRColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678647);
			HDRColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, 100678648);
		}

		// Token: 0x1700246E RID: 9326
		// (get) Token: 0x06007906 RID: 30982 RVA: 0x0020F9F8 File Offset: 0x0020DBF8
		// (set) Token: 0x06007907 RID: 30983 RVA: 0x0020FA34 File Offset: 0x0020DC34
		public unsafe Color CurrentValue
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31395, RefRangeEnd = 31396, XrefRangeStart = 31395, XrefRangeEnd = 31396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700246F RID: 9327
		// (get) Token: 0x06007908 RID: 30984 RVA: 0x0020FA74 File Offset: 0x0020DC74
		// (set) Token: 0x06007909 RID: 30985 RVA: 0x0020FAB0 File Offset: 0x0020DCB0
		public unsafe float Multiplier
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600790A RID: 30986 RVA: 0x0020FAF0 File Offset: 0x0020DCF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 235104, RefRangeEnd = 235105, XrefRangeStart = 235083, XrefRangeEnd = 235104, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_Initialize_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600790B RID: 30987 RVA: 0x0020FB24 File Offset: 0x0020DD24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235105, XrefRangeEnd = 235123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600790C RID: 30988 RVA: 0x0020FB58 File Offset: 0x0020DD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235123, XrefRangeEnd = 235126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDefault(Color value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_SetDefault_Public_Void_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600790D RID: 30989 RVA: 0x0020FB98 File Offset: 0x0020DD98
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 31396, RefRangeEnd = 31397, XrefRangeStart = 31396, XrefRangeEnd = 31397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetMultiplier(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600790E RID: 30990 RVA: 0x0020FBD8 File Offset: 0x0020DDD8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 235170, RefRangeEnd = 235176, XrefRangeStart = 235126, XrefRangeEnd = 235170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddOverride(Color value, int priority, string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref value;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x0020FC38 File Offset: 0x0020DE38
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 235212, RefRangeEnd = 235216, XrefRangeStart = 235176, XrefRangeEnd = 235212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveOverride(string label)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(label);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x0020FC7C File Offset: 0x0020DE7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235216, XrefRangeEnd = 235222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x0020FCB0 File Offset: 0x0020DEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 235222, XrefRangeEnd = 235230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HDRColorSmoother() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x00039155 File Offset: 0x00037355
		public HDRColorSmoother(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002469 RID: 9321
		// (get) Token: 0x06007913 RID: 30995 RVA: 0x0020FCEC File Offset: 0x0020DEEC
		// (set) Token: 0x06007914 RID: 30996 RVA: 0x0003915E File Offset: 0x0003735E
		public unsafe Color _CurrentValue_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__CurrentValue_k__BackingField)) = value;
			}
		}

		// Token: 0x1700246A RID: 9322
		// (get) Token: 0x06007915 RID: 30997 RVA: 0x0020FD14 File Offset: 0x0020DF14
		// (set) Token: 0x06007916 RID: 30998 RVA: 0x00039179 File Offset: 0x00037379
		public unsafe float _Multiplier_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr__Multiplier_k__BackingField)) = value;
			}
		}

		// Token: 0x1700246B RID: 9323
		// (get) Token: 0x06007917 RID: 30999 RVA: 0x0020FD3C File Offset: 0x0020DF3C
		// (set) Token: 0x06007918 RID: 31000 RVA: 0x00039194 File Offset: 0x00037394
		public unsafe Color DefaultValue
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_DefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_DefaultValue)) = value;
			}
		}

		// Token: 0x1700246C RID: 9324
		// (get) Token: 0x06007919 RID: 31001 RVA: 0x0020FD64 File Offset: 0x0020DF64
		// (set) Token: 0x0600791A RID: 31002 RVA: 0x000391AF File Offset: 0x000373AF
		public unsafe float SmoothingSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_SmoothingSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_SmoothingSpeed)) = value;
			}
		}

		// Token: 0x1700246D RID: 9325
		// (get) Token: 0x0600791B RID: 31003 RVA: 0x0020FD8C File Offset: 0x0020DF8C
		// (set) Token: 0x0600791C RID: 31004 RVA: 0x000391CA File Offset: 0x000373CA
		public unsafe List<HDRColorSmoother.Override> overrides
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_overrides);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<HDRColorSmoother.Override>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.NativeFieldInfoPtr_overrides), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040052A2 RID: 21154
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentValue_k__BackingField;

		// Token: 0x040052A3 RID: 21155
		private static readonly System.IntPtr NativeFieldInfoPtr__Multiplier_k__BackingField;

		// Token: 0x040052A4 RID: 21156
		private static readonly System.IntPtr NativeFieldInfoPtr_DefaultValue;

		// Token: 0x040052A5 RID: 21157
		private static readonly System.IntPtr NativeFieldInfoPtr_SmoothingSpeed;

		// Token: 0x040052A6 RID: 21158
		private static readonly System.IntPtr NativeFieldInfoPtr_overrides;

		// Token: 0x040052A7 RID: 21159
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentValue_Public_get_Color_0;

		// Token: 0x040052A8 RID: 21160
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentValue_Private_set_Void_Color_0;

		// Token: 0x040052A9 RID: 21161
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Multiplier_Public_get_Single_0;

		// Token: 0x040052AA RID: 21162
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Multiplier_Private_set_Void_Single_0;

		// Token: 0x040052AB RID: 21163
		private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Void_0;

		// Token: 0x040052AC RID: 21164
		private static readonly System.IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040052AD RID: 21165
		private static readonly System.IntPtr NativeMethodInfoPtr_SetDefault_Public_Void_Color_0;

		// Token: 0x040052AE RID: 21166
		private static readonly System.IntPtr NativeMethodInfoPtr_SetMultiplier_Public_Void_Single_0;

		// Token: 0x040052AF RID: 21167
		private static readonly System.IntPtr NativeMethodInfoPtr_AddOverride_Public_Void_Color_Int32_String_0;

		// Token: 0x040052B0 RID: 21168
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveOverride_Public_Void_String_0;

		// Token: 0x040052B1 RID: 21169
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

		// Token: 0x040052B2 RID: 21170
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AEF RID: 2799
		[System.Serializable]
		public class Override : Il2CppSystem.Object
		{
			// Token: 0x0600D834 RID: 55348 RVA: 0x0033CFC4 File Offset: 0x0033B1C4
			// Note: this type is marked as 'beforefieldinit'.
			static Override()
			{
				Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "Override");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr);
				HDRColorSmoother.Override.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, "Value");
				HDRColorSmoother.Override.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, "Priority");
				HDRColorSmoother.Override.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, "Label");
				HDRColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr, 100678649);
			}

			// Token: 0x0600D835 RID: 55349 RVA: 0x0033D040 File Offset: 0x0033B240
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Override() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.Override>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.Override.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D836 RID: 55350 RVA: 0x00068EA7 File Offset: 0x000670A7
			public Override(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042BF RID: 17087
			// (get) Token: 0x0600D837 RID: 55351 RVA: 0x0033D07C File Offset: 0x0033B27C
			// (set) Token: 0x0600D838 RID: 55352 RVA: 0x00068EB0 File Offset: 0x000670B0
			public unsafe Color Value
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Value);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Value)) = value;
				}
			}

			// Token: 0x170042C0 RID: 17088
			// (get) Token: 0x0600D839 RID: 55353 RVA: 0x0033D0A4 File Offset: 0x0033B2A4
			// (set) Token: 0x0600D83A RID: 55354 RVA: 0x00068ECB File Offset: 0x000670CB
			public unsafe int Priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Priority)) = value;
				}
			}

			// Token: 0x170042C1 RID: 17089
			// (get) Token: 0x0600D83B RID: 55355 RVA: 0x0033D0CC File Offset: 0x0033B2CC
			// (set) Token: 0x0600D83C RID: 55356 RVA: 0x00068EE6 File Offset: 0x000670E6
			public unsafe string Label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.Override.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091C3 RID: 37315
			private static readonly System.IntPtr NativeFieldInfoPtr_Value;

			// Token: 0x040091C4 RID: 37316
			private static readonly System.IntPtr NativeFieldInfoPtr_Priority;

			// Token: 0x040091C5 RID: 37317
			private static readonly System.IntPtr NativeFieldInfoPtr_Label;

			// Token: 0x040091C6 RID: 37318
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AF0 RID: 2800
		[ObfuscatedName("ScheduleOne.Tools.HDRColorSmoother+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D83D RID: 55357 RVA: 0x0033D0F4 File Offset: 0x0033B2F4
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr);
				HDRColorSmoother.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, "<>9");
				HDRColorSmoother.__c.NativeFieldInfoPtr___9__16_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, "<>9__16_1");
				HDRColorSmoother.__c.NativeFieldInfoPtr___9__17_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, "<>9__17_1");
				HDRColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, 100678651);
				HDRColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__16_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, 100678652);
				HDRColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__17_1_Internal_Int32_Override_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr, 100678653);
			}

			// Token: 0x0600D83E RID: 55358 RVA: 0x0033D198 File Offset: 0x0033B398
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D83F RID: 55359 RVA: 0x0033D1D4 File Offset: 0x0033B3D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _AddOverride_b__16_1(HDRColorSmoother.Override x, HDRColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c.NativeMethodInfoPtr__AddOverride_b__16_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D840 RID: 55360 RVA: 0x0033D234 File Offset: 0x0033B434
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _RemoveOverride_b__17_1(HDRColorSmoother.Override x, HDRColorSmoother.Override y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c.NativeMethodInfoPtr__RemoveOverride_b__17_1_Internal_Int32_Override_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D841 RID: 55361 RVA: 0x00068F05 File Offset: 0x00067105
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C2 RID: 17090
			// (get) Token: 0x0600D842 RID: 55362 RVA: 0x0033D294 File Offset: 0x0033B494
			// (set) Token: 0x0600D843 RID: 55363 RVA: 0x00068F0E File Offset: 0x0006710E
			public unsafe static HDRColorSmoother.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HDRColorSmoother.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C3 RID: 17091
			// (get) Token: 0x0600D844 RID: 55364 RVA: 0x0033D2BC File Offset: 0x0033B4BC
			// (set) Token: 0x0600D845 RID: 55365 RVA: 0x00068F20 File Offset: 0x00067120
			public unsafe static Il2CppSystem.Comparison<HDRColorSmoother.Override> __9__16_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__16_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HDRColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__16_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042C4 RID: 17092
			// (get) Token: 0x0600D846 RID: 55366 RVA: 0x0033D2E4 File Offset: 0x0033B4E4
			// (set) Token: 0x0600D847 RID: 55367 RVA: 0x00068F32 File Offset: 0x00067132
			public unsafe static Il2CppSystem.Comparison<HDRColorSmoother.Override> __9__17_1
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__17_1, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<HDRColorSmoother.Override>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(HDRColorSmoother.__c.NativeFieldInfoPtr___9__17_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091C7 RID: 37319
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040091C8 RID: 37320
			private static readonly System.IntPtr NativeFieldInfoPtr___9__16_1;

			// Token: 0x040091C9 RID: 37321
			private static readonly System.IntPtr NativeFieldInfoPtr___9__17_1;

			// Token: 0x040091CA RID: 37322
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091CB RID: 37323
			private static readonly System.IntPtr NativeMethodInfoPtr__AddOverride_b__16_1_Internal_Int32_Override_Override_0;

			// Token: 0x040091CC RID: 37324
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOverride_b__17_1_Internal_Int32_Override_Override_0;
		}

		// Token: 0x02000AF1 RID: 2801
		[ObfuscatedName("ScheduleOne.Tools.HDRColorSmoother+<>c__DisplayClass16_0")]
		public sealed class __c__DisplayClass16_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D848 RID: 55368 RVA: 0x0033D30C File Offset: 0x0033B50C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass16_0()
			{
				Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<>c__DisplayClass16_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr);
				HDRColorSmoother.__c__DisplayClass16_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr, "label");
				HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr, 100678654);
				HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr, 100678655);
			}

			// Token: 0x0600D849 RID: 55369 RVA: 0x0033D374 File Offset: 0x0033B574
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass16_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass16_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D84A RID: 55370 RVA: 0x0033D3B0 File Offset: 0x0033B5B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddOverride_b__0(HDRColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass16_0.NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D84B RID: 55371 RVA: 0x00068F44 File Offset: 0x00067144
			public __c__DisplayClass16_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C5 RID: 17093
			// (get) Token: 0x0600D84C RID: 55372 RVA: 0x0033D400 File Offset: 0x0033B600
			// (set) Token: 0x0600D84D RID: 55373 RVA: 0x00068F4D File Offset: 0x0006714D
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass16_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass16_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091CD RID: 37325
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040091CE RID: 37326
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091CF RID: 37327
			private static readonly System.IntPtr NativeMethodInfoPtr__AddOverride_b__0_Internal_Boolean_Override_0;
		}

		// Token: 0x02000AF2 RID: 2802
		[ObfuscatedName("ScheduleOne.Tools.HDRColorSmoother+<>c__DisplayClass17_0")]
		public sealed class __c__DisplayClass17_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D84E RID: 55374 RVA: 0x0033D428 File Offset: 0x0033B628
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass17_0()
			{
				Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HDRColorSmoother>.NativeClassPtr, "<>c__DisplayClass17_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr);
				HDRColorSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr, "label");
				HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678656);
				HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr, 100678657);
			}

			// Token: 0x0600D84F RID: 55375 RVA: 0x0033D490 File Offset: 0x0033B690
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass17_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HDRColorSmoother.__c__DisplayClass17_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D850 RID: 55376 RVA: 0x0033D4CC File Offset: 0x0033B6CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveOverride_b__0(HDRColorSmoother.Override x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(HDRColorSmoother.__c__DisplayClass17_0.NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D851 RID: 55377 RVA: 0x00068F6C File Offset: 0x0006716C
			public __c__DisplayClass17_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042C6 RID: 17094
			// (get) Token: 0x0600D852 RID: 55378 RVA: 0x0033D51C File Offset: 0x0033B71C
			// (set) Token: 0x0600D853 RID: 55379 RVA: 0x00068F75 File Offset: 0x00067175
			public unsafe string label
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(HDRColorSmoother.__c__DisplayClass17_0.NativeFieldInfoPtr_label), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040091D0 RID: 37328
			private static readonly System.IntPtr NativeFieldInfoPtr_label;

			// Token: 0x040091D1 RID: 37329
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040091D2 RID: 37330
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveOverride_b__0_Internal_Boolean_Override_0;
		}
	}
}
