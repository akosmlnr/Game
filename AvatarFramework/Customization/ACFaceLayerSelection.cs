using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.AvatarFramework.Customization
{
	// Token: 0x02000638 RID: 1592
	public class ACFaceLayerSelection : ACSelection<FaceLayer>
	{
		// Token: 0x06008BA7 RID: 35751 RVA: 0x0024D1D0 File Offset: 0x0024B3D0
		// Note: this type is marked as 'beforefieldinit'.
		static ACFaceLayerSelection()
		{
			Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework.Customization", "ACFaceLayerSelection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr);
			ACFaceLayerSelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680781);
			ACFaceLayerSelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680782);
			ACFaceLayerSelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680783);
			ACFaceLayerSelection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, 100680784);
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x0024D250 File Offset: 0x0024B450
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257350, XrefRangeEnd = 257353, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetOptionLabel(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACFaceLayerSelection.NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x0024D2A0 File Offset: 0x0024B4A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257353, XrefRangeEnd = 257365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CallValueChange()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACFaceLayerSelection.NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x0024D2DC File Offset: 0x0024B4DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257365, XrefRangeEnd = 257386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetAssetPathIndex(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ACFaceLayerSelection.NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06008BAB RID: 35755 RVA: 0x0024D334 File Offset: 0x0024B534
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257386, XrefRangeEnd = 257389, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ACFaceLayerSelection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerSelection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008BAC RID: 35756 RVA: 0x0004268B File Offset: 0x0004088B
		public ACFaceLayerSelection(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005EDC RID: 24284
		private static readonly System.IntPtr NativeMethodInfoPtr_GetOptionLabel_Public_Virtual_String_Int32_0;

		// Token: 0x04005EDD RID: 24285
		private static readonly System.IntPtr NativeMethodInfoPtr_CallValueChange_Public_Virtual_Void_0;

		// Token: 0x04005EDE RID: 24286
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAssetPathIndex_Public_Virtual_Int32_String_0;

		// Token: 0x04005EDF RID: 24287
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B56 RID: 2902
		[ObfuscatedName("ScheduleOne.AvatarFramework.Customization.ACFaceLayerSelection+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DB97 RID: 56215 RVA: 0x00346880 File Offset: 0x00344A80
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ACFaceLayerSelection>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr);
				ACFaceLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, "path");
				ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, 100680785);
				ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_FaceLayer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr, 100680786);
			}

			// Token: 0x0600DB98 RID: 56216 RVA: 0x003468E8 File Offset: 0x00344AE8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ACFaceLayerSelection.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DB99 RID: 56217 RVA: 0x00346924 File Offset: 0x00344B24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetAssetPathIndex_b__0(FaceLayer x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(ACFaceLayerSelection.__c__DisplayClass2_0.NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_FaceLayer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600DB9A RID: 56218 RVA: 0x0006A8D2 File Offset: 0x00068AD2
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170043BD RID: 17341
			// (get) Token: 0x0600DB9B RID: 56219 RVA: 0x00346974 File Offset: 0x00344B74
			// (set) Token: 0x0600DB9C RID: 56220 RVA: 0x0006A8DB File Offset: 0x00068ADB
			public unsafe string path
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACFaceLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ACFaceLayerSelection.__c__DisplayClass2_0.NativeFieldInfoPtr_path), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x040093BF RID: 37823
			private static readonly System.IntPtr NativeFieldInfoPtr_path;

			// Token: 0x040093C0 RID: 37824
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040093C1 RID: 37825
			private static readonly System.IntPtr NativeMethodInfoPtr__GetAssetPathIndex_b__0_Internal_Boolean_FaceLayer_0;
		}
	}
}
