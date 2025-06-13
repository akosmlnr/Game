using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x0200064E RID: 1614
	public class CanvasScaler : MonoBehaviour
	{
		// Token: 0x06008D60 RID: 36192 RVA: 0x002522BC File Offset: 0x002504BC
		// Note: this type is marked as 'beforefieldinit'.
		static CanvasScaler()
		{
			Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "CanvasScaler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr);
			CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "CanvasScaleFactor");
			CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "OnCanvasScaleFactorChanged");
			CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "ScaleMultiplier");
			CanvasScaler.NativeFieldInfoPtr_referenceResolution = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "referenceResolution");
			CanvasScaler.NativeFieldInfoPtr_canvasScaler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, "canvasScaler");
			CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680958);
			CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680959);
			CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680960);
			CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680961);
			CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680962);
			CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr, 100680963);
		}

		// Token: 0x17002AE7 RID: 10983
		// (get) Token: 0x06008D61 RID: 36193 RVA: 0x002523C8 File Offset: 0x002505C8
		public unsafe static float NormalizedCanvasScaleFactor
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 258836, RefRangeEnd = 258839, XrefRangeStart = 258832, XrefRangeEnd = 258836, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06008D62 RID: 36194 RVA: 0x002523F8 File Offset: 0x002505F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258839, XrefRangeEnd = 258869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_Awake_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D63 RID: 36195 RVA: 0x0025242C File Offset: 0x0025062C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258869, XrefRangeEnd = 258889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D64 RID: 36196 RVA: 0x00252460 File Offset: 0x00250660
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258889, XrefRangeEnd = 258895, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshScale()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_RefreshScale_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D65 RID: 36197 RVA: 0x00252494 File Offset: 0x00250694
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258900, RefRangeEnd = 258902, XrefRangeStart = 258895, XrefRangeEnd = 258900, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetScaleFactor(float scaleFactor)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref scaleFactor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D66 RID: 36198 RVA: 0x002524C8 File Offset: 0x002506C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258902, XrefRangeEnd = 258903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CanvasScaler() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CanvasScaler>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CanvasScaler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008D67 RID: 36199 RVA: 0x000436A2 File Offset: 0x000418A2
		public CanvasScaler(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x06008D68 RID: 36200 RVA: 0x00252504 File Offset: 0x00250704
		// (set) Token: 0x06008D69 RID: 36201 RVA: 0x000436AB File Offset: 0x000418AB
		public unsafe static float CanvasScaleFactor
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_CanvasScaleFactor, (void*)(&value));
			}
		}

		// Token: 0x17002AE3 RID: 10979
		// (get) Token: 0x06008D6A RID: 36202 RVA: 0x00252520 File Offset: 0x00250720
		// (set) Token: 0x06008D6B RID: 36203 RVA: 0x000436B9 File Offset: 0x000418B9
		public unsafe static Il2CppSystem.Action OnCanvasScaleFactorChanged
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CanvasScaler.NativeFieldInfoPtr_OnCanvasScaleFactorChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002AE4 RID: 10980
		// (get) Token: 0x06008D6C RID: 36204 RVA: 0x00252548 File Offset: 0x00250748
		// (set) Token: 0x06008D6D RID: 36205 RVA: 0x000436CB File Offset: 0x000418CB
		public unsafe float ScaleMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_ScaleMultiplier)) = value;
			}
		}

		// Token: 0x17002AE5 RID: 10981
		// (get) Token: 0x06008D6E RID: 36206 RVA: 0x00252570 File Offset: 0x00250770
		// (set) Token: 0x06008D6F RID: 36207 RVA: 0x000436E6 File Offset: 0x000418E6
		public unsafe Vector2 referenceResolution
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_referenceResolution);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_referenceResolution)) = value;
			}
		}

		// Token: 0x17002AE6 RID: 10982
		// (get) Token: 0x06008D70 RID: 36208 RVA: 0x00252598 File Offset: 0x00250798
		// (set) Token: 0x06008D71 RID: 36209 RVA: 0x00043701 File Offset: 0x00041901
		public unsafe CanvasScaler canvasScaler
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_canvasScaler);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasScaler>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CanvasScaler.NativeFieldInfoPtr_canvasScaler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005FE6 RID: 24550
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasScaleFactor;

		// Token: 0x04005FE7 RID: 24551
		private static readonly System.IntPtr NativeFieldInfoPtr_OnCanvasScaleFactorChanged;

		// Token: 0x04005FE8 RID: 24552
		private static readonly System.IntPtr NativeFieldInfoPtr_ScaleMultiplier;

		// Token: 0x04005FE9 RID: 24553
		private static readonly System.IntPtr NativeFieldInfoPtr_referenceResolution;

		// Token: 0x04005FEA RID: 24554
		private static readonly System.IntPtr NativeFieldInfoPtr_canvasScaler;

		// Token: 0x04005FEB RID: 24555
		private static readonly System.IntPtr NativeMethodInfoPtr_get_NormalizedCanvasScaleFactor_Public_Static_get_Single_0;

		// Token: 0x04005FEC RID: 24556
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Void_0;

		// Token: 0x04005FED RID: 24557
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005FEE RID: 24558
		private static readonly System.IntPtr NativeMethodInfoPtr_RefreshScale_Private_Void_0;

		// Token: 0x04005FEF RID: 24559
		private static readonly System.IntPtr NativeMethodInfoPtr_SetScaleFactor_Public_Static_Void_Single_0;

		// Token: 0x04005FF0 RID: 24560
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
