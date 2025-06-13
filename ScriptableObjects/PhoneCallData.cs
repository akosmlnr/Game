using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Quests;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.ScriptableObjects
{
	// Token: 0x020004D2 RID: 1234
	[System.Serializable]
	public class PhoneCallData : ScriptableObject
	{
		// Token: 0x06006BAD RID: 27565 RVA: 0x001E3A68 File Offset: 0x001E1C68
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallData()
		{
			Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ScriptableObjects", "PhoneCallData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr);
			PhoneCallData.NativeFieldInfoPtr_CallerID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "CallerID");
			PhoneCallData.NativeFieldInfoPtr_Stages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stages");
			PhoneCallData.NativeFieldInfoPtr_onCallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "onCallCompleted");
			PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100677060);
			PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, 100677061);
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x001E3AFC File Offset: 0x001E1CFC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 130895, RefRangeEnd = 130899, XrefRangeStart = 130895, XrefRangeEnd = 130899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Completed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr_Completed_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BAF RID: 27567 RVA: 0x001E3B30 File Offset: 0x001E1D30
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 92196, RefRangeEnd = 92208, XrefRangeStart = 92196, XrefRangeEnd = 92208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006BB0 RID: 27568 RVA: 0x00032A8C File Offset: 0x00030C8C
		public PhoneCallData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06006BB1 RID: 27569 RVA: 0x001E3B6C File Offset: 0x001E1D6C
		// (set) Token: 0x06006BB2 RID: 27570 RVA: 0x00032A95 File Offset: 0x00030C95
		public unsafe CallerID CallerID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallerID>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_CallerID), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06006BB3 RID: 27571 RVA: 0x001E3B9C File Offset: 0x001E1D9C
		// (set) Token: 0x06006BB4 RID: 27572 RVA: 0x00032AB4 File Offset: 0x00030CB4
		public unsafe Il2CppReferenceArray<PhoneCallData.Stage> Stages
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PhoneCallData.Stage>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_Stages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06006BB5 RID: 27573 RVA: 0x001E3BCC File Offset: 0x001E1DCC
		// (set) Token: 0x06006BB6 RID: 27574 RVA: 0x00032AD3 File Offset: 0x00030CD3
		public unsafe UnityEvent onCallCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.NativeFieldInfoPtr_onCallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040049C3 RID: 18883
		private static readonly System.IntPtr NativeFieldInfoPtr_CallerID;

		// Token: 0x040049C4 RID: 18884
		private static readonly System.IntPtr NativeFieldInfoPtr_Stages;

		// Token: 0x040049C5 RID: 18885
		private static readonly System.IntPtr NativeFieldInfoPtr_onCallCompleted;

		// Token: 0x040049C6 RID: 18886
		private static readonly System.IntPtr NativeMethodInfoPtr_Completed_Public_Void_0;

		// Token: 0x040049C7 RID: 18887
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A9E RID: 2718
		[System.Serializable]
		public class Stage : Il2CppSystem.Object
		{
			// Token: 0x0600D56B RID: 54635 RVA: 0x00335424 File Offset: 0x00333624
			// Note: this type is marked as 'beforefieldinit'.
			static Stage()
			{
				Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhoneCallData>.NativeClassPtr, "Stage");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr);
				PhoneCallData.Stage.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "Text");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnStartTriggers");
				PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, "OnDoneTriggers");
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100677062);
				PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100677063);
				PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr, 100677064);
			}

			// Token: 0x0600D56C RID: 54636 RVA: 0x003354C8 File Offset: 0x003336C8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 217274, RefRangeEnd = 217276, XrefRangeStart = 217272, XrefRangeEnd = 217274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageStart()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D56D RID: 54637 RVA: 0x003354FC File Offset: 0x003336FC
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 217278, RefRangeEnd = 217281, XrefRangeStart = 217276, XrefRangeEnd = 217278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void OnStageEnd()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr_OnStageEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D56E RID: 54638 RVA: 0x00335530 File Offset: 0x00333730
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Stage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallData.Stage>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallData.Stage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D56F RID: 54639 RVA: 0x00067895 File Offset: 0x00065A95
			public Stage(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041FA RID: 16890
			// (get) Token: 0x0600D570 RID: 54640 RVA: 0x0033556C File Offset: 0x0033376C
			// (set) Token: 0x0600D571 RID: 54641 RVA: 0x0006789E File Offset: 0x00065A9E
			public unsafe string Text
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x170041FB RID: 16891
			// (get) Token: 0x0600D572 RID: 54642 RVA: 0x00335594 File Offset: 0x00333794
			// (set) Token: 0x0600D573 RID: 54643 RVA: 0x000678BD File Offset: 0x00065ABD
			public unsafe Il2CppReferenceArray<SystemTrigger> OnStartTriggers
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnStartTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041FC RID: 16892
			// (get) Token: 0x0600D574 RID: 54644 RVA: 0x003355C4 File Offset: 0x003337C4
			// (set) Token: 0x0600D575 RID: 54645 RVA: 0x000678DC File Offset: 0x00065ADC
			public unsafe Il2CppReferenceArray<SystemTrigger> OnDoneTriggers
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SystemTrigger>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(PhoneCallData.Stage.NativeFieldInfoPtr_OnDoneTriggers), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009014 RID: 36884
			private static readonly System.IntPtr NativeFieldInfoPtr_Text;

			// Token: 0x04009015 RID: 36885
			private static readonly System.IntPtr NativeFieldInfoPtr_OnStartTriggers;

			// Token: 0x04009016 RID: 36886
			private static readonly System.IntPtr NativeFieldInfoPtr_OnDoneTriggers;

			// Token: 0x04009017 RID: 36887
			private static readonly System.IntPtr NativeMethodInfoPtr_OnStageStart_Public_Void_0;

			// Token: 0x04009018 RID: 36888
			private static readonly System.IntPtr NativeMethodInfoPtr_OnStageEnd_Public_Void_0;

			// Token: 0x04009019 RID: 36889
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
