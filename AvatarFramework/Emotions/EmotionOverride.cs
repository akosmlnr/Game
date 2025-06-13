using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Emotions
{
	// Token: 0x0200062A RID: 1578
	public class EmotionOverride : Il2CppSystem.Object
	{
		// Token: 0x06008A29 RID: 35369 RVA: 0x00248B8C File Offset: 0x00246D8C
		// Note: this type is marked as 'beforefieldinit'.
		static EmotionOverride()
		{
			Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Emotions", "EmotionOverride");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr);
			EmotionOverride.NativeFieldInfoPtr_Emotion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Emotion");
			EmotionOverride.NativeFieldInfoPtr_Label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Label");
			EmotionOverride.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, "Priority");
			EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr, 100680615);
		}

		// Token: 0x06008A2A RID: 35370 RVA: 0x00248C0C File Offset: 0x00246E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EmotionOverride(string emotion, string label, int priority) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EmotionOverride>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(emotion);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(label);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EmotionOverride.NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008A2B RID: 35371 RVA: 0x00041931 File Offset: 0x0003FB31
		public EmotionOverride(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x06008A2C RID: 35372 RVA: 0x00248C78 File Offset: 0x00246E78
		// (set) Token: 0x06008A2D RID: 35373 RVA: 0x0004193A File Offset: 0x0003FB3A
		public unsafe string Emotion
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Emotion), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x06008A2E RID: 35374 RVA: 0x00248CA0 File Offset: 0x00246EA0
		// (set) Token: 0x06008A2F RID: 35375 RVA: 0x00041959 File Offset: 0x0003FB59
		public unsafe string Label
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Label), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x06008A30 RID: 35376 RVA: 0x00248CC8 File Offset: 0x00246EC8
		// (set) Token: 0x06008A31 RID: 35377 RVA: 0x00041978 File Offset: 0x0003FB78
		public unsafe int Priority
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(EmotionOverride.NativeFieldInfoPtr_Priority)) = value;
			}
		}

		// Token: 0x04005DF1 RID: 24049
		private static readonly System.IntPtr NativeFieldInfoPtr_Emotion;

		// Token: 0x04005DF2 RID: 24050
		private static readonly System.IntPtr NativeFieldInfoPtr_Label;

		// Token: 0x04005DF3 RID: 24051
		private static readonly System.IntPtr NativeFieldInfoPtr_Priority;

		// Token: 0x04005DF4 RID: 24052
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_Int32_0;
	}
}
