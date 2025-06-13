using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.GameTime
{
	// Token: 0x0200019F RID: 415
	public class TutorialTimeController : MonoBehaviour
	{
		// Token: 0x060021EC RID: 8684 RVA: 0x000DD88C File Offset: 0x000DBA8C
		// Note: this type is marked as 'beforefieldinit'.
		static TutorialTimeController()
		{
			Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.GameTime", "TutorialTimeController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr);
			TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "TimeProgressionCurve");
			TutorialTimeController.NativeFieldInfoPtr_KeyFrames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrames");
			TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "currentKeyFrameIndex");
			TutorialTimeController.NativeFieldInfoPtr_disabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "disabled");
			TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667175);
			TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667176);
			TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667177);
			TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667178);
			TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667179);
			TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667180);
			TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, 100667181);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x000DD998 File Offset: 0x000DBB98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113931, XrefRangeEnd = 113949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x000DD9CC File Offset: 0x000DBBCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113949, XrefRangeEnd = 113967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x000DDA00 File Offset: 0x000DBC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113967, XrefRangeEnd = 113982, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x000DDA34 File Offset: 0x000DBC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113982, XrefRangeEnd = 113986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCurrentKeyFrameStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x000DDA70 File Offset: 0x000DBC70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113986, XrefRangeEnd = 113994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncrementKeyframe()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x000DDAA4 File Offset: 0x000DBCA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 113994, XrefRangeEnd = 113999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x000DDAD8 File Offset: 0x000DBCD8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TutorialTimeController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TutorialTimeController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x00012D27 File Offset: 0x00010F27
		public TutorialTimeController(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x060021F5 RID: 8693 RVA: 0x000DDB14 File Offset: 0x000DBD14
		// (set) Token: 0x060021F6 RID: 8694 RVA: 0x00012D30 File Offset: 0x00010F30
		public unsafe AnimationCurve TimeProgressionCurve
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_TimeProgressionCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x060021F7 RID: 8695 RVA: 0x000DDB44 File Offset: 0x000DBD44
		// (set) Token: 0x060021F8 RID: 8696 RVA: 0x00012D4F File Offset: 0x00010F4F
		public unsafe Il2CppReferenceArray<TutorialTimeController.KeyFrame> KeyFrames
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TutorialTimeController.KeyFrame>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_KeyFrames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x060021F9 RID: 8697 RVA: 0x000DDB74 File Offset: 0x000DBD74
		// (set) Token: 0x060021FA RID: 8698 RVA: 0x00012D6E File Offset: 0x00010F6E
		public unsafe int currentKeyFrameIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_currentKeyFrameIndex)) = value;
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x060021FB RID: 8699 RVA: 0x000DDB9C File Offset: 0x000DBD9C
		// (set) Token: 0x060021FC RID: 8700 RVA: 0x00012D89 File Offset: 0x00010F89
		public unsafe bool disabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.NativeFieldInfoPtr_disabled)) = value;
			}
		}

		// Token: 0x0400169B RID: 5787
		private static readonly System.IntPtr NativeFieldInfoPtr_TimeProgressionCurve;

		// Token: 0x0400169C RID: 5788
		private static readonly System.IntPtr NativeFieldInfoPtr_KeyFrames;

		// Token: 0x0400169D RID: 5789
		private static readonly System.IntPtr NativeFieldInfoPtr_currentKeyFrameIndex;

		// Token: 0x0400169E RID: 5790
		private static readonly System.IntPtr NativeFieldInfoPtr_disabled;

		// Token: 0x0400169F RID: 5791
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040016A0 RID: 5792
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040016A1 RID: 5793
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040016A2 RID: 5794
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentKeyFrameStart_Private_Int32_0;

		// Token: 0x040016A3 RID: 5795
		private static readonly System.IntPtr NativeMethodInfoPtr_IncrementKeyframe_Public_Void_0;

		// Token: 0x040016A4 RID: 5796
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040016A5 RID: 5797
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008EF RID: 2287
		[System.Serializable]
		public sealed class KeyFrame : Il2CppSystem.ValueType
		{
			// Token: 0x0600C7E7 RID: 51175 RVA: 0x0030E8A8 File Offset: 0x0030CAA8
			// Note: this type is marked as 'beforefieldinit'.
			static KeyFrame()
			{
				Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TutorialTimeController>.NativeClassPtr, "KeyFrame");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr);
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Time");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "SpeedMultiplier");
				TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr, "Note");
			}

			// Token: 0x0600C7E8 RID: 51176 RVA: 0x00060F37 File Offset: 0x0005F137
			public KeyFrame(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C7E9 RID: 51177 RVA: 0x00060F40 File Offset: 0x0005F140
			public KeyFrame() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TutorialTimeController.KeyFrame>.NativeClassPtr))
			{
			}

			// Token: 0x17003E25 RID: 15909
			// (get) Token: 0x0600C7EA RID: 51178 RVA: 0x0030E910 File Offset: 0x0030CB10
			// (set) Token: 0x0600C7EB RID: 51179 RVA: 0x00060F52 File Offset: 0x0005F152
			public unsafe int Time
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Time)) = value;
				}
			}

			// Token: 0x17003E26 RID: 15910
			// (get) Token: 0x0600C7EC RID: 51180 RVA: 0x0030E938 File Offset: 0x0030CB38
			// (set) Token: 0x0600C7ED RID: 51181 RVA: 0x00060F6D File Offset: 0x0005F16D
			public unsafe float SpeedMultiplier
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_SpeedMultiplier)) = value;
				}
			}

			// Token: 0x17003E27 RID: 15911
			// (get) Token: 0x0600C7EE RID: 51182 RVA: 0x0030E960 File Offset: 0x0030CB60
			// (set) Token: 0x0600C7EF RID: 51183 RVA: 0x00060F88 File Offset: 0x0005F188
			public unsafe string Note
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TutorialTimeController.KeyFrame.NativeFieldInfoPtr_Note), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040087A8 RID: 34728
			private static readonly System.IntPtr NativeFieldInfoPtr_Time;

			// Token: 0x040087A9 RID: 34729
			private static readonly System.IntPtr NativeFieldInfoPtr_SpeedMultiplier;

			// Token: 0x040087AA RID: 34730
			private static readonly System.IntPtr NativeFieldInfoPtr_Note;
		}
	}
}
