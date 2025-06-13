using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Levelling;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000689 RID: 1673
	public class RankUpCanvas : MonoBehaviour
	{
		// Token: 0x06009467 RID: 37991 RVA: 0x002671B4 File Offset: 0x002653B4
		// Note: this type is marked as 'beforefieldinit'.
		static RankUpCanvas()
		{
			Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "RankUpCanvas");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr);
			RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<IsRunning>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<Order>k__BackingField");
			RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OpenCloseAnim");
			RankUpCanvas.NativeFieldInfoPtr_RankUpAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "RankUpAnim");
			RankUpCanvas.NativeFieldInfoPtr_OldRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "OldRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_NewRankLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "NewRankLabel");
			RankUpCanvas.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "Canvas");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItemsContainer");
			RankUpCanvas.NativeFieldInfoPtr_UnlockedItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "UnlockedItems");
			RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ExtraUnlocksLabel");
			RankUpCanvas.NativeFieldInfoPtr_SoundEffect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "SoundEffect");
			RankUpCanvas.NativeFieldInfoPtr_ProgressSlider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressSlider");
			RankUpCanvas.NativeFieldInfoPtr_ProgressLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ProgressLabel");
			RankUpCanvas.NativeFieldInfoPtr_BlipSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "BlipSound");
			RankUpCanvas.NativeFieldInfoPtr_ClickSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "ClickSound");
			RankUpCanvas.NativeFieldInfoPtr_coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "coroutine");
			RankUpCanvas.NativeFieldInfoPtr_queuedRankUps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "queuedRankUps");
			RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681820);
			RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681821);
			RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681822);
			RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681823);
			RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681824);
			RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681825);
			RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681826);
			RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681827);
			RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681828);
			RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681829);
			RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, 100681830);
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x06009468 RID: 37992 RVA: 0x00267414 File Offset: 0x00265614
		// (set) Token: 0x06009469 RID: 37993 RVA: 0x00267450 File Offset: 0x00265650
		public unsafe virtual bool IsRunning
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002D50 RID: 11600
		// (get) Token: 0x0600946A RID: 37994 RVA: 0x00267490 File Offset: 0x00265690
		// (set) Token: 0x0600946B RID: 37995 RVA: 0x002674CC File Offset: 0x002656CC
		public unsafe virtual int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 31397, RefRangeEnd = 31398, XrefRangeStart = 31397, XrefRangeEnd = 31398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x0026750C File Offset: 0x0026570C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268156, XrefRangeEnd = 268188, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_Start_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600946D RID: 37997 RVA: 0x00267540 File Offset: 0x00265740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268188, XrefRangeEnd = 268194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueuePostSleepEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600946E RID: 37998 RVA: 0x00267574 File Offset: 0x00265774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268194, XrefRangeEnd = 268277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600946F RID: 37999 RVA: 0x002675A8 File Offset: 0x002657A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268277, XrefRangeEnd = 268286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_EndEvent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x002675DC File Offset: 0x002657DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268286, XrefRangeEnd = 268295, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RankUp(FullRank oldRank, FullRank newRank)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref newRank;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x00267628 File Offset: 0x00265828
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 268350, RefRangeEnd = 268351, XrefRangeStart = 268295, XrefRangeEnd = 268350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PlayRankupAnimation(FullRank oldRank, FullRank newRank, bool playSound)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref oldRank;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref newRank;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref playSound;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x00267684 File Offset: 0x00265884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268351, XrefRangeEnd = 268359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RankUpCanvas() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x000477BC File Offset: 0x000459BC
		public RankUpCanvas(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D3E RID: 11582
		// (get) Token: 0x06009474 RID: 38004 RVA: 0x002676C0 File Offset: 0x002658C0
		// (set) Token: 0x06009475 RID: 38005 RVA: 0x000477C5 File Offset: 0x000459C5
		public unsafe bool _IsRunning_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__IsRunning_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D3F RID: 11583
		// (get) Token: 0x06009476 RID: 38006 RVA: 0x002676E8 File Offset: 0x002658E8
		// (set) Token: 0x06009477 RID: 38007 RVA: 0x000477E0 File Offset: 0x000459E0
		public unsafe int _Order_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr__Order_k__BackingField)) = value;
			}
		}

		// Token: 0x17002D40 RID: 11584
		// (get) Token: 0x06009478 RID: 38008 RVA: 0x00267710 File Offset: 0x00265910
		// (set) Token: 0x06009479 RID: 38009 RVA: 0x000477FB File Offset: 0x000459FB
		public unsafe Animation OpenCloseAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OpenCloseAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600947A RID: 38010 RVA: 0x00267740 File Offset: 0x00265940
		// (set) Token: 0x0600947B RID: 38011 RVA: 0x0004781A File Offset: 0x00045A1A
		public unsafe Animation RankUpAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_RankUpAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600947C RID: 38012 RVA: 0x00267770 File Offset: 0x00265970
		// (set) Token: 0x0600947D RID: 38013 RVA: 0x00047839 File Offset: 0x00045A39
		public unsafe TextMeshProUGUI OldRankLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_OldRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600947E RID: 38014 RVA: 0x002677A0 File Offset: 0x002659A0
		// (set) Token: 0x0600947F RID: 38015 RVA: 0x00047858 File Offset: 0x00045A58
		public unsafe TextMeshProUGUI NewRankLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_NewRankLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x06009480 RID: 38016 RVA: 0x002677D0 File Offset: 0x002659D0
		// (set) Token: 0x06009481 RID: 38017 RVA: 0x00047877 File Offset: 0x00045A77
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x06009482 RID: 38018 RVA: 0x00267800 File Offset: 0x00265A00
		// (set) Token: 0x06009483 RID: 38019 RVA: 0x00047896 File Offset: 0x00045A96
		public unsafe GameObject UnlockedItemsContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItemsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D46 RID: 11590
		// (get) Token: 0x06009484 RID: 38020 RVA: 0x00267830 File Offset: 0x00265A30
		// (set) Token: 0x06009485 RID: 38021 RVA: 0x000478B5 File Offset: 0x00045AB5
		public unsafe Il2CppReferenceArray<RectTransform> UnlockedItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RectTransform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_UnlockedItems), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D47 RID: 11591
		// (get) Token: 0x06009486 RID: 38022 RVA: 0x00267860 File Offset: 0x00265A60
		// (set) Token: 0x06009487 RID: 38023 RVA: 0x000478D4 File Offset: 0x00045AD4
		public unsafe TextMeshProUGUI ExtraUnlocksLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ExtraUnlocksLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D48 RID: 11592
		// (get) Token: 0x06009488 RID: 38024 RVA: 0x00267890 File Offset: 0x00265A90
		// (set) Token: 0x06009489 RID: 38025 RVA: 0x000478F3 File Offset: 0x00045AF3
		public unsafe AudioSourceController SoundEffect
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_SoundEffect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D49 RID: 11593
		// (get) Token: 0x0600948A RID: 38026 RVA: 0x002678C0 File Offset: 0x00265AC0
		// (set) Token: 0x0600948B RID: 38027 RVA: 0x00047912 File Offset: 0x00045B12
		public unsafe Slider ProgressSlider
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressSlider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4A RID: 11594
		// (get) Token: 0x0600948C RID: 38028 RVA: 0x002678F0 File Offset: 0x00265AF0
		// (set) Token: 0x0600948D RID: 38029 RVA: 0x00047931 File Offset: 0x00045B31
		public unsafe TextMeshProUGUI ProgressLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ProgressLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4B RID: 11595
		// (get) Token: 0x0600948E RID: 38030 RVA: 0x00267920 File Offset: 0x00265B20
		// (set) Token: 0x0600948F RID: 38031 RVA: 0x00047950 File Offset: 0x00045B50
		public unsafe AudioSourceController BlipSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_BlipSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4C RID: 11596
		// (get) Token: 0x06009490 RID: 38032 RVA: 0x00267950 File Offset: 0x00265B50
		// (set) Token: 0x06009491 RID: 38033 RVA: 0x0004796F File Offset: 0x00045B6F
		public unsafe AudioSourceController ClickSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_ClickSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4D RID: 11597
		// (get) Token: 0x06009492 RID: 38034 RVA: 0x00267980 File Offset: 0x00265B80
		// (set) Token: 0x06009493 RID: 38035 RVA: 0x0004798E File Offset: 0x00045B8E
		public unsafe Coroutine coroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x06009494 RID: 38036 RVA: 0x002679B0 File Offset: 0x00265BB0
		// (set) Token: 0x06009495 RID: 38037 RVA: 0x000479AD File Offset: 0x00045BAD
		public unsafe List<Il2CppSystem.Tuple<FullRank, FullRank>> queuedRankUps
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Tuple<FullRank, FullRank>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.NativeFieldInfoPtr_queuedRankUps), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006451 RID: 25681
		private static readonly System.IntPtr NativeFieldInfoPtr__IsRunning_k__BackingField;

		// Token: 0x04006452 RID: 25682
		private static readonly System.IntPtr NativeFieldInfoPtr__Order_k__BackingField;

		// Token: 0x04006453 RID: 25683
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenCloseAnim;

		// Token: 0x04006454 RID: 25684
		private static readonly System.IntPtr NativeFieldInfoPtr_RankUpAnim;

		// Token: 0x04006455 RID: 25685
		private static readonly System.IntPtr NativeFieldInfoPtr_OldRankLabel;

		// Token: 0x04006456 RID: 25686
		private static readonly System.IntPtr NativeFieldInfoPtr_NewRankLabel;

		// Token: 0x04006457 RID: 25687
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006458 RID: 25688
		private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedItemsContainer;

		// Token: 0x04006459 RID: 25689
		private static readonly System.IntPtr NativeFieldInfoPtr_UnlockedItems;

		// Token: 0x0400645A RID: 25690
		private static readonly System.IntPtr NativeFieldInfoPtr_ExtraUnlocksLabel;

		// Token: 0x0400645B RID: 25691
		private static readonly System.IntPtr NativeFieldInfoPtr_SoundEffect;

		// Token: 0x0400645C RID: 25692
		private static readonly System.IntPtr NativeFieldInfoPtr_ProgressSlider;

		// Token: 0x0400645D RID: 25693
		private static readonly System.IntPtr NativeFieldInfoPtr_ProgressLabel;

		// Token: 0x0400645E RID: 25694
		private static readonly System.IntPtr NativeFieldInfoPtr_BlipSound;

		// Token: 0x0400645F RID: 25695
		private static readonly System.IntPtr NativeFieldInfoPtr_ClickSound;

		// Token: 0x04006460 RID: 25696
		private static readonly System.IntPtr NativeFieldInfoPtr_coroutine;

		// Token: 0x04006461 RID: 25697
		private static readonly System.IntPtr NativeFieldInfoPtr_queuedRankUps;

		// Token: 0x04006462 RID: 25698
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsRunning_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04006463 RID: 25699
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsRunning_Private_set_Void_Boolean_0;

		// Token: 0x04006464 RID: 25700
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Order_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04006465 RID: 25701
		private static readonly System.IntPtr NativeMethodInfoPtr_set_Order_Private_set_Void_Int32_0;

		// Token: 0x04006466 RID: 25702
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Void_0;

		// Token: 0x04006467 RID: 25703
		private static readonly System.IntPtr NativeMethodInfoPtr_QueuePostSleepEvent_Private_Void_0;

		// Token: 0x04006468 RID: 25704
		private static readonly System.IntPtr NativeMethodInfoPtr_StartEvent_Public_Virtual_Final_New_Void_0;

		// Token: 0x04006469 RID: 25705
		private static readonly System.IntPtr NativeMethodInfoPtr_EndEvent_Public_Void_0;

		// Token: 0x0400646A RID: 25706
		private static readonly System.IntPtr NativeMethodInfoPtr_RankUp_Public_Void_FullRank_FullRank_0;

		// Token: 0x0400646B RID: 25707
		private static readonly System.IntPtr NativeMethodInfoPtr_PlayRankupAnimation_Private_Void_FullRank_FullRank_Boolean_0;

		// Token: 0x0400646C RID: 25708
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B9C RID: 2972
		[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass25_0")]
		public sealed class __c__DisplayClass25_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DEAF RID: 57007 RVA: 0x0034F7DC File Offset: 0x0034D9DC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass25_0()
			{
				Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas>.NativeClassPtr, "<>c__DisplayClass25_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr);
				RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "progressDisplays");
				RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "<>4__this");
				RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, 100681831);
				RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, 100681832);
			}

			// Token: 0x0600DEB0 RID: 57008 RVA: 0x0034F858 File Offset: 0x0034DA58
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass25_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DEB1 RID: 57009 RVA: 0x0034F894 File Offset: 0x0034DA94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268151, XrefRangeEnd = 268156, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DEB2 RID: 57010 RVA: 0x0006C23F File Offset: 0x0006A43F
			public __c__DisplayClass25_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044C9 RID: 17609
			// (get) Token: 0x0600DEB3 RID: 57011 RVA: 0x0034F8D4 File Offset: 0x0034DAD4
			// (set) Token: 0x0600DEB4 RID: 57012 RVA: 0x0006C248 File Offset: 0x0006A448
			public unsafe List<Il2CppSystem.Tuple<FullRank, int, int>> progressDisplays
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Tuple<FullRank, int, int>>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr_progressDisplays), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044CA RID: 17610
			// (get) Token: 0x0600DEB5 RID: 57013 RVA: 0x0034F904 File Offset: 0x0034DB04
			// (set) Token: 0x0600DEB6 RID: 57014 RVA: 0x0006C267 File Offset: 0x0006A467
			public unsafe RankUpCanvas __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095A8 RID: 38312
			private static readonly System.IntPtr NativeFieldInfoPtr_progressDisplays;

			// Token: 0x040095A9 RID: 38313
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095AA RID: 38314
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040095AB RID: 38315
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD4 RID: 3284
			[ObfuscatedName("ScheduleOne.UI.RankUpCanvas+<>c__DisplayClass25_0+<<StartEvent>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EB61 RID: 60257 RVA: 0x00373FF4 File Offset: 0x003721F4
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique()
				{
					Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0>.NativeClassPtr, "<<StartEvent>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>1__state");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>2__current");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>4__this");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<rankSoundPlayed>5__2");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<>7__wrap2");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<progress>5__4");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<oldRank>5__5");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<newRank>5__6");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<startXP>5__7");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<endXP>5__8");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<lerpTime>5__9");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<xpForRank>5__10");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipSpacing>5__11");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<blipTime>5__12");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, "<i>5__13");
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681833);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681834);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681835);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681836);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681837);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681838);
					RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr, 100681839);
				}

				// Token: 0x0600EB62 RID: 60258 RVA: 0x003741D8 File Offset: 0x003723D8
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB63 RID: 60259 RVA: 0x00374220 File Offset: 0x00372420
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268042, XrefRangeEnd = 268047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EB64 RID: 60260 RVA: 0x00374254 File Offset: 0x00372454
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268047, XrefRangeEnd = 268143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x0600EB65 RID: 60261 RVA: 0x00374290 File Offset: 0x00372490
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268143, XrefRangeEnd = 268146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void __m__Finally1()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr___m__Finally1_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048F2 RID: 18674
				// (get) Token: 0x0600EB66 RID: 60262 RVA: 0x003742C4 File Offset: 0x003724C4
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB67 RID: 60263 RVA: 0x00374304 File Offset: 0x00372504
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268146, XrefRangeEnd = 268151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048F3 RID: 18675
				// (get) Token: 0x0600EB68 RID: 60264 RVA: 0x00374338 File Offset: 0x00372538
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EB69 RID: 60265 RVA: 0x00072828 File Offset: 0x00070A28
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048E3 RID: 18659
				// (get) Token: 0x0600EB6A RID: 60266 RVA: 0x00374378 File Offset: 0x00372578
				// (set) Token: 0x0600EB6B RID: 60267 RVA: 0x00072831 File Offset: 0x00070A31
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048E4 RID: 18660
				// (get) Token: 0x0600EB6C RID: 60268 RVA: 0x003743A0 File Offset: 0x003725A0
				// (set) Token: 0x0600EB6D RID: 60269 RVA: 0x0007284C File Offset: 0x00070A4C
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048E5 RID: 18661
				// (get) Token: 0x0600EB6E RID: 60270 RVA: 0x003743D0 File Offset: 0x003725D0
				// (set) Token: 0x0600EB6F RID: 60271 RVA: 0x0007286B File Offset: 0x00070A6B
				public unsafe RankUpCanvas.__c__DisplayClass25_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<RankUpCanvas.__c__DisplayClass25_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048E6 RID: 18662
				// (get) Token: 0x0600EB70 RID: 60272 RVA: 0x00374400 File Offset: 0x00372600
				// (set) Token: 0x0600EB71 RID: 60273 RVA: 0x0007288A File Offset: 0x00070A8A
				public unsafe bool _rankSoundPlayed_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__rankSoundPlayed_5__2)) = value;
					}
				}

				// Token: 0x170048E7 RID: 18663
				// (get) Token: 0x0600EB72 RID: 60274 RVA: 0x00374428 File Offset: 0x00372628
				// (set) Token: 0x0600EB73 RID: 60275 RVA: 0x000728A5 File Offset: 0x00070AA5
				public List<Il2CppSystem.Tuple<FullRank, int, int>>.Enumerator __7__wrap2
				{
					get
					{
						System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2);
						return new List<Il2CppSystem.Tuple<FullRank, int, int>>.Enumerator(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<List<Il2CppSystem.Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, data));
					}
					set
					{
						cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr___7__wrap2), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<List<Il2CppSystem.Tuple<FullRank, int, int>>.Enumerator>.NativeClassPtr, (System.UIntPtr)0));
					}
				}

				// Token: 0x170048E8 RID: 18664
				// (get) Token: 0x0600EB74 RID: 60276 RVA: 0x00374458 File Offset: 0x00372658
				// (set) Token: 0x0600EB75 RID: 60277 RVA: 0x000728D3 File Offset: 0x00070AD3
				public unsafe Il2CppSystem.Tuple<FullRank, int, int> _progress_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Tuple<FullRank, int, int>>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__progress_5__4), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048E9 RID: 18665
				// (get) Token: 0x0600EB76 RID: 60278 RVA: 0x00374488 File Offset: 0x00372688
				// (set) Token: 0x0600EB77 RID: 60279 RVA: 0x000728F2 File Offset: 0x00070AF2
				public unsafe FullRank _oldRank_5__5
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__oldRank_5__5)) = value;
					}
				}

				// Token: 0x170048EA RID: 18666
				// (get) Token: 0x0600EB78 RID: 60280 RVA: 0x003744B0 File Offset: 0x003726B0
				// (set) Token: 0x0600EB79 RID: 60281 RVA: 0x0007290D File Offset: 0x00070B0D
				public unsafe FullRank _newRank_5__6
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__newRank_5__6)) = value;
					}
				}

				// Token: 0x170048EB RID: 18667
				// (get) Token: 0x0600EB7A RID: 60282 RVA: 0x003744D8 File Offset: 0x003726D8
				// (set) Token: 0x0600EB7B RID: 60283 RVA: 0x00072928 File Offset: 0x00070B28
				public unsafe int _startXP_5__7
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__startXP_5__7)) = value;
					}
				}

				// Token: 0x170048EC RID: 18668
				// (get) Token: 0x0600EB7C RID: 60284 RVA: 0x00374500 File Offset: 0x00372700
				// (set) Token: 0x0600EB7D RID: 60285 RVA: 0x00072943 File Offset: 0x00070B43
				public unsafe int _endXP_5__8
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__endXP_5__8)) = value;
					}
				}

				// Token: 0x170048ED RID: 18669
				// (get) Token: 0x0600EB7E RID: 60286 RVA: 0x00374528 File Offset: 0x00372728
				// (set) Token: 0x0600EB7F RID: 60287 RVA: 0x0007295E File Offset: 0x00070B5E
				public unsafe float _lerpTime_5__9
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__lerpTime_5__9)) = value;
					}
				}

				// Token: 0x170048EE RID: 18670
				// (get) Token: 0x0600EB80 RID: 60288 RVA: 0x00374550 File Offset: 0x00372750
				// (set) Token: 0x0600EB81 RID: 60289 RVA: 0x00072979 File Offset: 0x00070B79
				public unsafe int _xpForRank_5__10
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__xpForRank_5__10)) = value;
					}
				}

				// Token: 0x170048EF RID: 18671
				// (get) Token: 0x0600EB82 RID: 60290 RVA: 0x00374578 File Offset: 0x00372778
				// (set) Token: 0x0600EB83 RID: 60291 RVA: 0x00072994 File Offset: 0x00070B94
				public unsafe float _blipSpacing_5__11
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipSpacing_5__11)) = value;
					}
				}

				// Token: 0x170048F0 RID: 18672
				// (get) Token: 0x0600EB84 RID: 60292 RVA: 0x003745A0 File Offset: 0x003727A0
				// (set) Token: 0x0600EB85 RID: 60293 RVA: 0x000729AF File Offset: 0x00070BAF
				public unsafe float _blipTime_5__12
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__blipTime_5__12)) = value;
					}
				}

				// Token: 0x170048F1 RID: 18673
				// (get) Token: 0x0600EB86 RID: 60294 RVA: 0x003745C8 File Offset: 0x003727C8
				// (set) Token: 0x0600EB87 RID: 60295 RVA: 0x000729CA File Offset: 0x00070BCA
				public unsafe float _i_5__13
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(RankUpCanvas.__c__DisplayClass25_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoEn1Tu3FuSiInUnique.NativeFieldInfoPtr__i_5__13)) = value;
					}
				}

				// Token: 0x04009D6A RID: 40298
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D6B RID: 40299
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D6C RID: 40300
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D6D RID: 40301
				private static readonly System.IntPtr NativeFieldInfoPtr__rankSoundPlayed_5__2;

				// Token: 0x04009D6E RID: 40302
				private static readonly System.IntPtr NativeFieldInfoPtr___7__wrap2;

				// Token: 0x04009D6F RID: 40303
				private static readonly System.IntPtr NativeFieldInfoPtr__progress_5__4;

				// Token: 0x04009D70 RID: 40304
				private static readonly System.IntPtr NativeFieldInfoPtr__oldRank_5__5;

				// Token: 0x04009D71 RID: 40305
				private static readonly System.IntPtr NativeFieldInfoPtr__newRank_5__6;

				// Token: 0x04009D72 RID: 40306
				private static readonly System.IntPtr NativeFieldInfoPtr__startXP_5__7;

				// Token: 0x04009D73 RID: 40307
				private static readonly System.IntPtr NativeFieldInfoPtr__endXP_5__8;

				// Token: 0x04009D74 RID: 40308
				private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__9;

				// Token: 0x04009D75 RID: 40309
				private static readonly System.IntPtr NativeFieldInfoPtr__xpForRank_5__10;

				// Token: 0x04009D76 RID: 40310
				private static readonly System.IntPtr NativeFieldInfoPtr__blipSpacing_5__11;

				// Token: 0x04009D77 RID: 40311
				private static readonly System.IntPtr NativeFieldInfoPtr__blipTime_5__12;

				// Token: 0x04009D78 RID: 40312
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__13;

				// Token: 0x04009D79 RID: 40313
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D7A RID: 40314
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D7B RID: 40315
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D7C RID: 40316
				private static readonly System.IntPtr NativeMethodInfoPtr___m__Finally1_Private_Void_0;

				// Token: 0x04009D7D RID: 40317
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D7E RID: 40318
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D7F RID: 40319
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
