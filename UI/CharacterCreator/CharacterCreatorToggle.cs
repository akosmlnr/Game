using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.CharacterCreator
{
	// Token: 0x0200072A RID: 1834
	public class CharacterCreatorToggle : CharacterCreatorField<int>
	{
		// Token: 0x0600A383 RID: 41859 RVA: 0x00294668 File Offset: 0x00292868
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterCreatorToggle()
		{
			Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.CharacterCreator", "CharacterCreatorToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr);
			CharacterCreatorToggle.NativeFieldInfoPtr_Button1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button1");
			CharacterCreatorToggle.NativeFieldInfoPtr_Button2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, "Button2");
			CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100683390);
			CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100683391);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100683392);
			CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100683393);
			CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr, 100683394);
		}

		// Token: 0x0600A384 RID: 41860 RVA: 0x00294724 File Offset: 0x00292924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287413, XrefRangeEnd = 287427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A385 RID: 41861 RVA: 0x00294760 File Offset: 0x00292960
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287427, XrefRangeEnd = 287434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ApplyValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CharacterCreatorToggle.NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A386 RID: 41862 RVA: 0x0029479C File Offset: 0x0029299C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287434, XrefRangeEnd = 287435, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton1()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton1_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A387 RID: 41863 RVA: 0x002947D0 File Offset: 0x002929D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287435, XrefRangeEnd = 287436, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnButton2()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr_OnButton2_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A388 RID: 41864 RVA: 0x00294804 File Offset: 0x00292A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 287436, XrefRangeEnd = 287439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CharacterCreatorToggle() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterCreatorToggle>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CharacterCreatorToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A389 RID: 41865 RVA: 0x0005035B File Offset: 0x0004E55B
		public CharacterCreatorToggle(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003230 RID: 12848
		// (get) Token: 0x0600A38A RID: 41866 RVA: 0x00294840 File Offset: 0x00292A40
		// (set) Token: 0x0600A38B RID: 41867 RVA: 0x00050364 File Offset: 0x0004E564
		public unsafe Button Button1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003231 RID: 12849
		// (get) Token: 0x0600A38C RID: 41868 RVA: 0x00294870 File Offset: 0x00292A70
		// (set) Token: 0x0600A38D RID: 41869 RVA: 0x00050383 File Offset: 0x0004E583
		public unsafe Button Button2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CharacterCreatorToggle.NativeFieldInfoPtr_Button2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006D9D RID: 28061
		private static readonly IntPtr NativeFieldInfoPtr_Button1;

		// Token: 0x04006D9E RID: 28062
		private static readonly IntPtr NativeFieldInfoPtr_Button2;

		// Token: 0x04006D9F RID: 28063
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006DA0 RID: 28064
		private static readonly IntPtr NativeMethodInfoPtr_ApplyValue_Public_Virtual_Void_0;

		// Token: 0x04006DA1 RID: 28065
		private static readonly IntPtr NativeMethodInfoPtr_OnButton1_Public_Void_0;

		// Token: 0x04006DA2 RID: 28066
		private static readonly IntPtr NativeMethodInfoPtr_OnButton2_Public_Void_0;

		// Token: 0x04006DA3 RID: 28067
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
