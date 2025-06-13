using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.PlayerTasks;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ObjectScripts.Soil
{
	// Token: 0x0200078E RID: 1934
	public class PourableSoil : Pourable
	{
		// Token: 0x0600B788 RID: 46984 RVA: 0x002DEC38 File Offset: 0x002DCE38
		// Note: this type is marked as 'beforefieldinit'.
		static PourableSoil()
		{
			Il2CppClassPointerStore<PourableSoil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Soil", "PourableSoil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr);
			PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TEAR_ANGLE");
			PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "HIGHLIGHT_CYCLE_TIME");
			PourableSoil.NativeFieldInfoPtr_IsOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "IsOpen");
			PourableSoil.NativeFieldInfoPtr_SoilDefinition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilDefinition");
			PourableSoil.NativeFieldInfoPtr_SoilBag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SoilBag");
			PourableSoil.NativeFieldInfoPtr_Bones = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Bones");
			PourableSoil.NativeFieldInfoPtr_TopColliders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopColliders");
			PourableSoil.NativeFieldInfoPtr_Highlights = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "Highlights");
			PourableSoil.NativeFieldInfoPtr_TopParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopParent");
			PourableSoil.NativeFieldInfoPtr_SnipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "SnipSound");
			PourableSoil.NativeFieldInfoPtr_TopMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "TopMesh");
			PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<currentCut>k__BackingField");
			PourableSoil.NativeFieldInfoPtr_onOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "onOpened");
			PourableSoil.NativeFieldInfoPtr_highlightScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "highlightScale");
			PourableSoil.NativeFieldInfoPtr_timeSinceStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "timeSinceStart");
			PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686075);
			PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686076);
			PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686077);
			PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686078);
			PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686079);
			PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686080);
			PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686081);
			PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686082);
			PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686083);
			PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686084);
			PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, 100686085);
		}

		// Token: 0x170038A8 RID: 14504
		// (get) Token: 0x0600B789 RID: 46985 RVA: 0x002DEE70 File Offset: 0x002DD070
		// (set) Token: 0x0600B78A RID: 46986 RVA: 0x002DEEAC File Offset: 0x002DD0AC
		public unsafe int currentCut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B78B RID: 46987 RVA: 0x002DEEEC File Offset: 0x002DD0EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314878, XrefRangeEnd = 314882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B78C RID: 46988 RVA: 0x002DEF28 File Offset: 0x002DD128
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314882, XrefRangeEnd = 314885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B78D RID: 46989 RVA: 0x002DEF64 File Offset: 0x002DD164
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314898, RefRangeEnd = 314900, XrefRangeStart = 314885, XrefRangeEnd = 314898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateHighlights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_UpdateHighlights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B78E RID: 46990 RVA: 0x002DEF98 File Offset: 0x002DD198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314900, XrefRangeEnd = 314912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PourAmount(float amount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref amount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B78F RID: 46991 RVA: 0x002DEFE4 File Offset: 0x002DD1E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314912, XrefRangeEnd = 314913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool CanPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourableSoil.NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B790 RID: 46992 RVA: 0x002DF02C File Offset: 0x002DD22C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314920, RefRangeEnd = 314921, XrefRangeStart = 314913, XrefRangeEnd = 314920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_Cut_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B791 RID: 46993 RVA: 0x002DF060 File Offset: 0x002DD260
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314946, RefRangeEnd = 314947, XrefRangeStart = 314921, XrefRangeEnd = 314946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinishCut()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_FinishCut_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B792 RID: 46994 RVA: 0x002DF094 File Offset: 0x002DD294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314963, RefRangeEnd = 314964, XrefRangeStart = 314947, XrefRangeEnd = 314963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpCut(int cutIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref cutIndex;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B793 RID: 46995 RVA: 0x002DF0D4 File Offset: 0x002DD2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314964, XrefRangeEnd = 314967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourableSoil() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B794 RID: 46996 RVA: 0x000598EC File Offset: 0x00057AEC
		public PourableSoil(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600B795 RID: 46997 RVA: 0x002DF110 File Offset: 0x002DD310
		// (set) Token: 0x0600B796 RID: 46998 RVA: 0x000598F5 File Offset: 0x00057AF5
		public unsafe static float TEAR_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_TEAR_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600B797 RID: 46999 RVA: 0x002DF12C File Offset: 0x002DD32C
		// (set) Token: 0x0600B798 RID: 47000 RVA: 0x00059903 File Offset: 0x00057B03
		public unsafe static float HIGHLIGHT_CYCLE_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PourableSoil.NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME, (void*)(&value));
			}
		}

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600B799 RID: 47001 RVA: 0x002DF148 File Offset: 0x002DD348
		// (set) Token: 0x0600B79A RID: 47002 RVA: 0x00059911 File Offset: 0x00057B11
		public unsafe bool IsOpen
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_IsOpen)) = value;
			}
		}

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600B79B RID: 47003 RVA: 0x002DF170 File Offset: 0x002DD370
		// (set) Token: 0x0600B79C RID: 47004 RVA: 0x0005992C File Offset: 0x00057B2C
		public unsafe SoilDefinition SoilDefinition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SoilDefinition>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilDefinition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389D RID: 14493
		// (get) Token: 0x0600B79D RID: 47005 RVA: 0x002DF1A0 File Offset: 0x002DD3A0
		// (set) Token: 0x0600B79E RID: 47006 RVA: 0x0005994B File Offset: 0x00057B4B
		public unsafe Transform SoilBag
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SoilBag), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389E RID: 14494
		// (get) Token: 0x0600B79F RID: 47007 RVA: 0x002DF1D0 File Offset: 0x002DD3D0
		// (set) Token: 0x0600B7A0 RID: 47008 RVA: 0x0005996A File Offset: 0x00057B6A
		public unsafe Il2CppReferenceArray<Transform> Bones
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Bones), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700389F RID: 14495
		// (get) Token: 0x0600B7A1 RID: 47009 RVA: 0x002DF200 File Offset: 0x002DD400
		// (set) Token: 0x0600B7A2 RID: 47010 RVA: 0x00059989 File Offset: 0x00057B89
		public unsafe List<Collider> TopColliders
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Collider>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopColliders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A0 RID: 14496
		// (get) Token: 0x0600B7A3 RID: 47011 RVA: 0x002DF230 File Offset: 0x002DD430
		// (set) Token: 0x0600B7A4 RID: 47012 RVA: 0x000599A8 File Offset: 0x00057BA8
		public unsafe Il2CppReferenceArray<MeshRenderer> Highlights
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_Highlights), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A1 RID: 14497
		// (get) Token: 0x0600B7A5 RID: 47013 RVA: 0x002DF260 File Offset: 0x002DD460
		// (set) Token: 0x0600B7A6 RID: 47014 RVA: 0x000599C7 File Offset: 0x00057BC7
		public unsafe Transform TopParent
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopParent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A2 RID: 14498
		// (get) Token: 0x0600B7A7 RID: 47015 RVA: 0x002DF290 File Offset: 0x002DD490
		// (set) Token: 0x0600B7A8 RID: 47016 RVA: 0x000599E6 File Offset: 0x00057BE6
		public unsafe AudioSourceController SnipSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_SnipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A3 RID: 14499
		// (get) Token: 0x0600B7A9 RID: 47017 RVA: 0x002DF2C0 File Offset: 0x002DD4C0
		// (set) Token: 0x0600B7AA RID: 47018 RVA: 0x00059A05 File Offset: 0x00057C05
		public unsafe SkinnedMeshRenderer TopMesh
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SkinnedMeshRenderer>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_TopMesh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A4 RID: 14500
		// (get) Token: 0x0600B7AB RID: 47019 RVA: 0x002DF2F0 File Offset: 0x002DD4F0
		// (set) Token: 0x0600B7AC RID: 47020 RVA: 0x00059A24 File Offset: 0x00057C24
		public unsafe int _currentCut_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr__currentCut_k__BackingField)) = value;
			}
		}

		// Token: 0x170038A5 RID: 14501
		// (get) Token: 0x0600B7AD RID: 47021 RVA: 0x002DF318 File Offset: 0x002DD518
		// (set) Token: 0x0600B7AE RID: 47022 RVA: 0x00059A3F File Offset: 0x00057C3F
		public unsafe UnityEvent onOpened
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_onOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038A6 RID: 14502
		// (get) Token: 0x0600B7AF RID: 47023 RVA: 0x002DF348 File Offset: 0x002DD548
		// (set) Token: 0x0600B7B0 RID: 47024 RVA: 0x00059A5E File Offset: 0x00057C5E
		public unsafe Vector3 highlightScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_highlightScale)) = value;
			}
		}

		// Token: 0x170038A7 RID: 14503
		// (get) Token: 0x0600B7B1 RID: 47025 RVA: 0x002DF370 File Offset: 0x002DD570
		// (set) Token: 0x0600B7B2 RID: 47026 RVA: 0x00059A79 File Offset: 0x00057C79
		public unsafe float timeSinceStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.NativeFieldInfoPtr_timeSinceStart)) = value;
			}
		}

		// Token: 0x04007BEF RID: 31727
		private static readonly System.IntPtr NativeFieldInfoPtr_TEAR_ANGLE;

		// Token: 0x04007BF0 RID: 31728
		private static readonly System.IntPtr NativeFieldInfoPtr_HIGHLIGHT_CYCLE_TIME;

		// Token: 0x04007BF1 RID: 31729
		private static readonly System.IntPtr NativeFieldInfoPtr_IsOpen;

		// Token: 0x04007BF2 RID: 31730
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilDefinition;

		// Token: 0x04007BF3 RID: 31731
		private static readonly System.IntPtr NativeFieldInfoPtr_SoilBag;

		// Token: 0x04007BF4 RID: 31732
		private static readonly System.IntPtr NativeFieldInfoPtr_Bones;

		// Token: 0x04007BF5 RID: 31733
		private static readonly System.IntPtr NativeFieldInfoPtr_TopColliders;

		// Token: 0x04007BF6 RID: 31734
		private static readonly System.IntPtr NativeFieldInfoPtr_Highlights;

		// Token: 0x04007BF7 RID: 31735
		private static readonly System.IntPtr NativeFieldInfoPtr_TopParent;

		// Token: 0x04007BF8 RID: 31736
		private static readonly System.IntPtr NativeFieldInfoPtr_SnipSound;

		// Token: 0x04007BF9 RID: 31737
		private static readonly System.IntPtr NativeFieldInfoPtr_TopMesh;

		// Token: 0x04007BFA RID: 31738
		private static readonly System.IntPtr NativeFieldInfoPtr__currentCut_k__BackingField;

		// Token: 0x04007BFB RID: 31739
		private static readonly System.IntPtr NativeFieldInfoPtr_onOpened;

		// Token: 0x04007BFC RID: 31740
		private static readonly System.IntPtr NativeFieldInfoPtr_highlightScale;

		// Token: 0x04007BFD RID: 31741
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceStart;

		// Token: 0x04007BFE RID: 31742
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentCut_Public_get_Int32_0;

		// Token: 0x04007BFF RID: 31743
		private static readonly System.IntPtr NativeMethodInfoPtr_set_currentCut_Protected_set_Void_Int32_0;

		// Token: 0x04007C00 RID: 31744
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04007C01 RID: 31745
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04007C02 RID: 31746
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateHighlights_Private_Void_0;

		// Token: 0x04007C03 RID: 31747
		private static readonly System.IntPtr NativeMethodInfoPtr_PourAmount_Protected_Virtual_Void_Single_0;

		// Token: 0x04007C04 RID: 31748
		private static readonly System.IntPtr NativeMethodInfoPtr_CanPour_Protected_Virtual_Boolean_0;

		// Token: 0x04007C05 RID: 31749
		private static readonly System.IntPtr NativeMethodInfoPtr_Cut_Public_Void_0;

		// Token: 0x04007C06 RID: 31750
		private static readonly System.IntPtr NativeMethodInfoPtr_FinishCut_Private_Void_0;

		// Token: 0x04007C07 RID: 31751
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpCut_Private_Void_Int32_0;

		// Token: 0x04007C08 RID: 31752
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C52 RID: 3154
		[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600E540 RID: 58688 RVA: 0x00362150 File Offset: 0x00360350
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr);
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "bone");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "startRot");
				PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "endRot");
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100686086);
				PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, 100686087);
			}

			// Token: 0x0600E541 RID: 58689 RVA: 0x003621E0 File Offset: 0x003603E0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E542 RID: 58690 RVA: 0x0036221C File Offset: 0x0036041C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314873, XrefRangeEnd = 314878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600E543 RID: 58691 RVA: 0x0006F7AA File Offset: 0x0006D9AA
			public __c__DisplayClass25_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046BC RID: 18108
			// (get) Token: 0x0600E544 RID: 58692 RVA: 0x0036225C File Offset: 0x0036045C
			// (set) Token: 0x0600E545 RID: 58693 RVA: 0x0006F7B3 File Offset: 0x0006D9B3
			public unsafe Transform bone
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_bone), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046BD RID: 18109
			// (get) Token: 0x0600E546 RID: 58694 RVA: 0x0036228C File Offset: 0x0036048C
			// (set) Token: 0x0600E547 RID: 58695 RVA: 0x0006F7D2 File Offset: 0x0006D9D2
			public unsafe Quaternion startRot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_startRot)) = value;
				}
			}

			// Token: 0x170046BE RID: 18110
			// (get) Token: 0x0600E548 RID: 58696 RVA: 0x003622B4 File Offset: 0x003604B4
			// (set) Token: 0x0600E549 RID: 58697 RVA: 0x0006F7ED File Offset: 0x0006D9ED
			public unsafe Quaternion endRot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.NativeFieldInfoPtr_endRot)) = value;
				}
			}

			// Token: 0x0400999A RID: 39322
			private static readonly System.IntPtr NativeFieldInfoPtr_bone;

			// Token: 0x0400999B RID: 39323
			private static readonly System.IntPtr NativeFieldInfoPtr_startRot;

			// Token: 0x0400999C RID: 39324
			private static readonly System.IntPtr NativeFieldInfoPtr_endRot;

			// Token: 0x0400999D RID: 39325
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400999E RID: 39326
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CEE RID: 3310
			[ObfuscatedName("ScheduleOne.ObjectScripts.Soil.PourableSoil+<>c__DisplayClass25_0+<<LerpCut>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600ED27 RID: 60711 RVA: 0x00379354 File Offset: 0x00377554
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0>.NativeClassPtr, "<<LerpCut>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<lerpTime>5__2");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<i>5__3");
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686088);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686089);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686090);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686091);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686092);
					PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100686093);
				}

				// Token: 0x0600ED28 RID: 60712 RVA: 0x0037945C File Offset: 0x0037765C
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600ED29 RID: 60713 RVA: 0x003794A4 File Offset: 0x003776A4
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600ED2A RID: 60714 RVA: 0x003794D8 File Offset: 0x003776D8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314859, XrefRangeEnd = 314868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004997 RID: 18839
				// (get) Token: 0x0600ED2B RID: 60715 RVA: 0x00379514 File Offset: 0x00377714
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600ED2C RID: 60716 RVA: 0x00379554 File Offset: 0x00377754
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314868, XrefRangeEnd = 314873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004998 RID: 18840
				// (get) Token: 0x0600ED2D RID: 60717 RVA: 0x00379588 File Offset: 0x00377788
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600ED2E RID: 60718 RVA: 0x00073734 File Offset: 0x00071934
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004992 RID: 18834
				// (get) Token: 0x0600ED2F RID: 60719 RVA: 0x003795C8 File Offset: 0x003777C8
				// (set) Token: 0x0600ED30 RID: 60720 RVA: 0x0007373D File Offset: 0x0007193D
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004993 RID: 18835
				// (get) Token: 0x0600ED31 RID: 60721 RVA: 0x003795F0 File Offset: 0x003777F0
				// (set) Token: 0x0600ED32 RID: 60722 RVA: 0x00073758 File Offset: 0x00071958
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004994 RID: 18836
				// (get) Token: 0x0600ED33 RID: 60723 RVA: 0x00379620 File Offset: 0x00377820
				// (set) Token: 0x0600ED34 RID: 60724 RVA: 0x00073777 File Offset: 0x00071977
				public unsafe PourableSoil.__c__DisplayClass25_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<PourableSoil.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004995 RID: 18837
				// (get) Token: 0x0600ED35 RID: 60725 RVA: 0x00379650 File Offset: 0x00377850
				// (set) Token: 0x0600ED36 RID: 60726 RVA: 0x00073796 File Offset: 0x00071996
				public unsafe float _lerpTime_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__lerpTime_5__2)) = value;
					}
				}

				// Token: 0x17004996 RID: 18838
				// (get) Token: 0x0600ED37 RID: 60727 RVA: 0x00379678 File Offset: 0x00377878
				// (set) Token: 0x0600ED38 RID: 60728 RVA: 0x000737B1 File Offset: 0x000719B1
				public unsafe float _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PourableSoil.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009E7F RID: 40575
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009E80 RID: 40576
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009E81 RID: 40577
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009E82 RID: 40578
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__2;

				// Token: 0x04009E83 RID: 40579
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009E84 RID: 40580
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009E85 RID: 40581
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E86 RID: 40582
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009E87 RID: 40583
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009E88 RID: 40584
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009E89 RID: 40585
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
