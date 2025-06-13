using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.Economy;
using Il2CppScheduleOne.Quests;
using Il2CppScheduleOne.UI.Relations;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000655 RID: 1621
	public class DealCompletionPopup : Singleton<DealCompletionPopup>
	{
		// Token: 0x06008E3B RID: 36411 RVA: 0x00254F58 File Offset: 0x00253158
		// Note: this type is marked as 'beforefieldinit'.
		static DealCompletionPopup()
		{
			Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "DealCompletionPopup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr);
			DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<IsPlaying>k__BackingField");
			DealCompletionPopup.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Canvas");
			DealCompletionPopup.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Container");
			DealCompletionPopup.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Group");
			DealCompletionPopup.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Anim");
			DealCompletionPopup.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "Title");
			DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "PaymentLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionValueLabel");
			DealCompletionPopup.NativeFieldInfoPtr_RelationCircle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationCircle");
			DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "RelationshipLabel");
			DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SatisfactionGradient");
			DealCompletionPopup.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "SoundEffect");
			DealCompletionPopup.NativeFieldInfoPtr_BonusLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "BonusLabels");
			DealCompletionPopup.NativeFieldInfoPtr_routine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "routine");
			DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100681065);
			DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100681066);
			DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100681067);
			DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100681068);
			DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100681069);
			DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, 100681070);
		}

		// Token: 0x17002B35 RID: 11061
		// (get) Token: 0x06008E3C RID: 36412 RVA: 0x00255118 File Offset: 0x00253318
		// (set) Token: 0x06008E3D RID: 36413 RVA: 0x00255154 File Offset: 0x00253354
		public unsafe bool IsPlaying
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 40119, RefRangeEnd = 40138, XrefRangeStart = 40119, XrefRangeEnd = 40138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06008E3E RID: 36414 RVA: 0x00255194 File Offset: 0x00253394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260185, XrefRangeEnd = 260192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DealCompletionPopup.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E3F RID: 36415 RVA: 0x002551D0 File Offset: 0x002533D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 260208, RefRangeEnd = 260209, XrefRangeStart = 260192, XrefRangeEnd = 260208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayPopup(Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, List<Contract.BonusPayment> bonuses)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(customer);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref satisfaction;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref originalRelationshipDelta;
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref basePayment;
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bonuses);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x00255250 File Offset: 0x00253450
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 260217, RefRangeEnd = 260220, XrefRangeStart = 260209, XrefRangeEnd = 260217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetRelationshipLabel(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref delta;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x00255290 File Offset: 0x00253490
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260220, XrefRangeEnd = 260223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DealCompletionPopup() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008E42 RID: 36418 RVA: 0x00043D84 File Offset: 0x00041F84
		public DealCompletionPopup(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B27 RID: 11047
		// (get) Token: 0x06008E43 RID: 36419 RVA: 0x002552CC File Offset: 0x002534CC
		// (set) Token: 0x06008E44 RID: 36420 RVA: 0x00043D8D File Offset: 0x00041F8D
		public unsafe bool _IsPlaying_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr__IsPlaying_k__BackingField)) = value;
			}
		}

		// Token: 0x17002B28 RID: 11048
		// (get) Token: 0x06008E45 RID: 36421 RVA: 0x002552F4 File Offset: 0x002534F4
		// (set) Token: 0x06008E46 RID: 36422 RVA: 0x00043DA8 File Offset: 0x00041FA8
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B29 RID: 11049
		// (get) Token: 0x06008E47 RID: 36423 RVA: 0x00255324 File Offset: 0x00253524
		// (set) Token: 0x06008E48 RID: 36424 RVA: 0x00043DC7 File Offset: 0x00041FC7
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2A RID: 11050
		// (get) Token: 0x06008E49 RID: 36425 RVA: 0x00255354 File Offset: 0x00253554
		// (set) Token: 0x06008E4A RID: 36426 RVA: 0x00043DE6 File Offset: 0x00041FE6
		public unsafe CanvasGroup Group
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2B RID: 11051
		// (get) Token: 0x06008E4B RID: 36427 RVA: 0x00255384 File Offset: 0x00253584
		// (set) Token: 0x06008E4C RID: 36428 RVA: 0x00043E05 File Offset: 0x00042005
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2C RID: 11052
		// (get) Token: 0x06008E4D RID: 36429 RVA: 0x002553B4 File Offset: 0x002535B4
		// (set) Token: 0x06008E4E RID: 36430 RVA: 0x00043E24 File Offset: 0x00042024
		public unsafe TextMeshProUGUI Title
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_Title), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2D RID: 11053
		// (get) Token: 0x06008E4F RID: 36431 RVA: 0x002553E4 File Offset: 0x002535E4
		// (set) Token: 0x06008E50 RID: 36432 RVA: 0x00043E43 File Offset: 0x00042043
		public unsafe TextMeshProUGUI PaymentLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_PaymentLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2E RID: 11054
		// (get) Token: 0x06008E51 RID: 36433 RVA: 0x00255414 File Offset: 0x00253614
		// (set) Token: 0x06008E52 RID: 36434 RVA: 0x00043E62 File Offset: 0x00042062
		public unsafe TextMeshProUGUI SatisfactionValueLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionValueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B2F RID: 11055
		// (get) Token: 0x06008E53 RID: 36435 RVA: 0x00255444 File Offset: 0x00253644
		// (set) Token: 0x06008E54 RID: 36436 RVA: 0x00043E81 File Offset: 0x00042081
		public unsafe RelationCircle RelationCircle
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RelationCircle>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationCircle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B30 RID: 11056
		// (get) Token: 0x06008E55 RID: 36437 RVA: 0x00255474 File Offset: 0x00253674
		// (set) Token: 0x06008E56 RID: 36438 RVA: 0x00043EA0 File Offset: 0x000420A0
		public unsafe TextMeshProUGUI RelationshipLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_RelationshipLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B31 RID: 11057
		// (get) Token: 0x06008E57 RID: 36439 RVA: 0x002554A4 File Offset: 0x002536A4
		// (set) Token: 0x06008E58 RID: 36440 RVA: 0x00043EBF File Offset: 0x000420BF
		public unsafe Gradient SatisfactionGradient
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Gradient>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SatisfactionGradient), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B32 RID: 11058
		// (get) Token: 0x06008E59 RID: 36441 RVA: 0x002554D4 File Offset: 0x002536D4
		// (set) Token: 0x06008E5A RID: 36442 RVA: 0x00043EDE File Offset: 0x000420DE
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B33 RID: 11059
		// (get) Token: 0x06008E5B RID: 36443 RVA: 0x00255504 File Offset: 0x00253704
		// (set) Token: 0x06008E5C RID: 36444 RVA: 0x00043EFD File Offset: 0x000420FD
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> BonusLabels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_BonusLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B34 RID: 11060
		// (get) Token: 0x06008E5D RID: 36445 RVA: 0x00255534 File Offset: 0x00253734
		// (set) Token: 0x06008E5E RID: 36446 RVA: 0x00043F1C File Offset: 0x0004211C
		public unsafe Coroutine routine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.NativeFieldInfoPtr_routine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006079 RID: 24697
		private static readonly System.IntPtr NativeFieldInfoPtr__IsPlaying_k__BackingField;

		// Token: 0x0400607A RID: 24698
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400607B RID: 24699
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x0400607C RID: 24700
		private static readonly System.IntPtr NativeFieldInfoPtr_Group;

		// Token: 0x0400607D RID: 24701
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x0400607E RID: 24702
		private static readonly System.IntPtr NativeFieldInfoPtr_Title;

		// Token: 0x0400607F RID: 24703
		private static readonly System.IntPtr NativeFieldInfoPtr_PaymentLabel;

		// Token: 0x04006080 RID: 24704
		private static readonly System.IntPtr NativeFieldInfoPtr_SatisfactionValueLabel;

		// Token: 0x04006081 RID: 24705
		private static readonly System.IntPtr NativeFieldInfoPtr_RelationCircle;

		// Token: 0x04006082 RID: 24706
		private static readonly System.IntPtr NativeFieldInfoPtr_RelationshipLabel;

		// Token: 0x04006083 RID: 24707
		private static readonly System.IntPtr NativeFieldInfoPtr_SatisfactionGradient;

		// Token: 0x04006084 RID: 24708
		private static readonly System.IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x04006085 RID: 24709
		private static readonly System.IntPtr NativeFieldInfoPtr_BonusLabels;

		// Token: 0x04006086 RID: 24710
		private static readonly System.IntPtr NativeFieldInfoPtr_routine;

		// Token: 0x04006087 RID: 24711
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsPlaying_Public_get_Boolean_0;

		// Token: 0x04006088 RID: 24712
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsPlaying_Protected_set_Void_Boolean_0;

		// Token: 0x04006089 RID: 24713
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400608A RID: 24714
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayPopup_Public_Void_Customer_Single_Single_Single_List_1_BonusPayment_0;

		// Token: 0x0400608B RID: 24715
		private static readonly System.IntPtr NativeMethodInfoPtr_SetRelationshipLabel_Private_Void_Single_0;

		// Token: 0x0400608C RID: 24716
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B68 RID: 2920
		[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<>c__DisplayClass18_0")]
		public sealed class __c__DisplayClass18_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DC18 RID: 56344 RVA: 0x00348088 File Offset: 0x00346288
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass18_0()
			{
				Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup>.NativeClassPtr, "<>c__DisplayClass18_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr);
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "<>4__this");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "customer");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "bonuses");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "originalRelationshipDelta");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "basePayment");
				DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "satisfaction");
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100681071);
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100681072);
				DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, 100681073);
			}

			// Token: 0x0600DC19 RID: 56345 RVA: 0x00348168 File Offset: 0x00346368
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass18_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DC1A RID: 56346 RVA: 0x003481A4 File Offset: 0x003463A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260179, XrefRangeEnd = 260184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DC1B RID: 56347 RVA: 0x003481E4 File Offset: 0x003463E4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260184, XrefRangeEnd = 260185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _PlayPopup_b__1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DC1C RID: 56348 RVA: 0x0006ACA6 File Offset: 0x00068EA6
			public __c__DisplayClass18_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043DF RID: 17375
			// (get) Token: 0x0600DC1D RID: 56349 RVA: 0x00348220 File Offset: 0x00346420
			// (set) Token: 0x0600DC1E RID: 56350 RVA: 0x0006ACAF File Offset: 0x00068EAF
			public unsafe DealCompletionPopup __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E0 RID: 17376
			// (get) Token: 0x0600DC1F RID: 56351 RVA: 0x00348250 File Offset: 0x00346450
			// (set) Token: 0x0600DC20 RID: 56352 RVA: 0x0006ACCE File Offset: 0x00068ECE
			public unsafe Customer customer
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Customer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_customer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E1 RID: 17377
			// (get) Token: 0x0600DC21 RID: 56353 RVA: 0x00348280 File Offset: 0x00346480
			// (set) Token: 0x0600DC22 RID: 56354 RVA: 0x0006ACED File Offset: 0x00068EED
			public unsafe List<Contract.BonusPayment> bonuses
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Contract.BonusPayment>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_bonuses), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170043E2 RID: 17378
			// (get) Token: 0x0600DC23 RID: 56355 RVA: 0x003482B0 File Offset: 0x003464B0
			// (set) Token: 0x0600DC24 RID: 56356 RVA: 0x0006AD0C File Offset: 0x00068F0C
			public unsafe float originalRelationshipDelta
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_originalRelationshipDelta)) = value;
				}
			}

			// Token: 0x170043E3 RID: 17379
			// (get) Token: 0x0600DC25 RID: 56357 RVA: 0x003482D8 File Offset: 0x003464D8
			// (set) Token: 0x0600DC26 RID: 56358 RVA: 0x0006AD27 File Offset: 0x00068F27
			public unsafe float basePayment
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_basePayment)) = value;
				}
			}

			// Token: 0x170043E4 RID: 17380
			// (get) Token: 0x0600DC27 RID: 56359 RVA: 0x00348300 File Offset: 0x00346500
			// (set) Token: 0x0600DC28 RID: 56360 RVA: 0x0006AD42 File Offset: 0x00068F42
			public unsafe float satisfaction
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.NativeFieldInfoPtr_satisfaction)) = value;
				}
			}

			// Token: 0x04009412 RID: 37906
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009413 RID: 37907
			private static readonly System.IntPtr NativeFieldInfoPtr_customer;

			// Token: 0x04009414 RID: 37908
			private static readonly System.IntPtr NativeFieldInfoPtr_bonuses;

			// Token: 0x04009415 RID: 37909
			private static readonly System.IntPtr NativeFieldInfoPtr_originalRelationshipDelta;

			// Token: 0x04009416 RID: 37910
			private static readonly System.IntPtr NativeFieldInfoPtr_basePayment;

			// Token: 0x04009417 RID: 37911
			private static readonly System.IntPtr NativeFieldInfoPtr_satisfaction;

			// Token: 0x04009418 RID: 37912
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009419 RID: 37913
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x0400941A RID: 37914
			private static readonly System.IntPtr NativeMethodInfoPtr__PlayPopup_b__1_Internal_Boolean_0;

			// Token: 0x02000CCC RID: 3276
			[ObfuscatedName("ScheduleOne.UI.DealCompletionPopup+<>c__DisplayClass18_0+<<PlayPopup>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EAC7 RID: 60103 RVA: 0x00372460 File Offset: 0x00370660
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique()
				{
					Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0>.NativeClassPtr, "<<PlayPopup>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>1__state");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>2__current");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<>4__this");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<paymentLerpTime>5__2");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<satisfactionLerpTime>5__3");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<endDelta>5__4");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<lerpTime>5__5");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, "<i>5__6");
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100681074);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100681075);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100681076);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100681077);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100681078);
					DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr, 100681079);
				}

				// Token: 0x0600EAC8 RID: 60104 RVA: 0x003725A4 File Offset: 0x003707A4
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAC9 RID: 60105 RVA: 0x003725EC File Offset: 0x003707EC
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EACA RID: 60106 RVA: 0x00372620 File Offset: 0x00370820
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260060, XrefRangeEnd = 260174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048AE RID: 18606
				// (get) Token: 0x0600EACB RID: 60107 RVA: 0x0037265C File Offset: 0x0037085C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EACC RID: 60108 RVA: 0x0037269C File Offset: 0x0037089C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 260174, XrefRangeEnd = 260179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048AF RID: 18607
				// (get) Token: 0x0600EACD RID: 60109 RVA: 0x003726D0 File Offset: 0x003708D0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EACE RID: 60110 RVA: 0x000722DD File Offset: 0x000704DD
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048A6 RID: 18598
				// (get) Token: 0x0600EACF RID: 60111 RVA: 0x00372710 File Offset: 0x00370910
				// (set) Token: 0x0600EAD0 RID: 60112 RVA: 0x000722E6 File Offset: 0x000704E6
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048A7 RID: 18599
				// (get) Token: 0x0600EAD1 RID: 60113 RVA: 0x00372738 File Offset: 0x00370938
				// (set) Token: 0x0600EAD2 RID: 60114 RVA: 0x00072301 File Offset: 0x00070501
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048A8 RID: 18600
				// (get) Token: 0x0600EAD3 RID: 60115 RVA: 0x00372768 File Offset: 0x00370968
				// (set) Token: 0x0600EAD4 RID: 60116 RVA: 0x00072320 File Offset: 0x00070520
				public unsafe DealCompletionPopup.__c__DisplayClass18_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<DealCompletionPopup.__c__DisplayClass18_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048A9 RID: 18601
				// (get) Token: 0x0600EAD5 RID: 60117 RVA: 0x00372798 File Offset: 0x00370998
				// (set) Token: 0x0600EAD6 RID: 60118 RVA: 0x0007233F File Offset: 0x0007053F
				public unsafe float _paymentLerpTime_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__paymentLerpTime_5__2)) = value;
					}
				}

				// Token: 0x170048AA RID: 18602
				// (get) Token: 0x0600EAD7 RID: 60119 RVA: 0x003727C0 File Offset: 0x003709C0
				// (set) Token: 0x0600EAD8 RID: 60120 RVA: 0x0007235A File Offset: 0x0007055A
				public unsafe float _satisfactionLerpTime_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__satisfactionLerpTime_5__3)) = value;
					}
				}

				// Token: 0x170048AB RID: 18603
				// (get) Token: 0x0600EAD9 RID: 60121 RVA: 0x003727E8 File Offset: 0x003709E8
				// (set) Token: 0x0600EADA RID: 60122 RVA: 0x00072375 File Offset: 0x00070575
				public unsafe float _endDelta_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__endDelta_5__4)) = value;
					}
				}

				// Token: 0x170048AC RID: 18604
				// (get) Token: 0x0600EADB RID: 60123 RVA: 0x00372810 File Offset: 0x00370A10
				// (set) Token: 0x0600EADC RID: 60124 RVA: 0x00072390 File Offset: 0x00070590
				public unsafe float _lerpTime_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__lerpTime_5__5)) = value;
					}
				}

				// Token: 0x170048AD RID: 18605
				// (get) Token: 0x0600EADD RID: 60125 RVA: 0x00372838 File Offset: 0x00370A38
				// (set) Token: 0x0600EADE RID: 60126 RVA: 0x000723AB File Offset: 0x000705AB
				public unsafe float _i_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(DealCompletionPopup.__c__DisplayClass18_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObSiObSiSiUnique.NativeFieldInfoPtr__i_5__6)) = value;
					}
				}

				// Token: 0x04009D0D RID: 40205
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D0E RID: 40206
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D0F RID: 40207
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D10 RID: 40208
				private static readonly System.IntPtr NativeFieldInfoPtr__paymentLerpTime_5__2;

				// Token: 0x04009D11 RID: 40209
				private static readonly System.IntPtr NativeFieldInfoPtr__satisfactionLerpTime_5__3;

				// Token: 0x04009D12 RID: 40210
				private static readonly System.IntPtr NativeFieldInfoPtr__endDelta_5__4;

				// Token: 0x04009D13 RID: 40211
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__5;

				// Token: 0x04009D14 RID: 40212
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__6;

				// Token: 0x04009D15 RID: 40213
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D16 RID: 40214
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D17 RID: 40215
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D18 RID: 40216
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D19 RID: 40217
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D1A RID: 40218
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
