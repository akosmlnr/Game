using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Management.Presets
{
	// Token: 0x020003CD RID: 973
	public class Preset : Il2CppSystem.Object
	{
		// Token: 0x06004AFF RID: 19199 RVA: 0x0016EA40 File Offset: 0x0016CC40
		// Note: this type is marked as 'beforefieldinit'.
		static Preset()
		{
			Il2CppClassPointerStore<Preset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets", "Preset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Preset>.NativeClassPtr);
			Preset.NativeFieldInfoPtr_PresetName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetName");
			Preset.NativeFieldInfoPtr_PresetColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetColor");
			Preset.NativeFieldInfoPtr_ObjectType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "ObjectType");
			Preset.NativeFieldInfoPtr_onNameChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "onNameChanged");
			Preset.NativeFieldInfoPtr_onDeleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Preset>.NativeClassPtr, "onDeleted");
			Preset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672679);
			Preset.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672680);
			Preset.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672681);
			Preset.NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672682);
			Preset.NativeMethodInfoPtr_SetName_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672683);
			Preset.NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672684);
			Preset.NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset>.NativeClassPtr, 100672685);
		}

		// Token: 0x06004B00 RID: 19200 RVA: 0x0016EB60 File Offset: 0x0016CD60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168073, RefRangeEnd = 168075, XrefRangeStart = 168073, XrefRangeEnd = 168075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Preset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B01 RID: 19201 RVA: 0x0016EB9C File Offset: 0x0016CD9C
		[CallerCount(0)]
		public unsafe virtual Preset GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
		}

		// Token: 0x06004B02 RID: 19202 RVA: 0x0016EBE8 File Offset: 0x0016CDE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168075, XrefRangeEnd = 168076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Preset other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B03 RID: 19203 RVA: 0x0016EC38 File Offset: 0x0016CE38
		[CallerCount(0)]
		public unsafe virtual void InitializeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Preset.NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B04 RID: 19204 RVA: 0x0016EC74 File Offset: 0x0016CE74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168076, XrefRangeEnd = 168078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetName(string newName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(newName);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_SetName_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B05 RID: 19205 RVA: 0x0016ECB8 File Offset: 0x0016CEB8
		[CallerCount(0)]
		public unsafe void DeletePreset(Preset replacement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B06 RID: 19206 RVA: 0x0016ECFC File Offset: 0x0016CEFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168078, XrefRangeEnd = 168084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Preset GetDefault(ManageableObjectType type)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
		}

		// Token: 0x06004B07 RID: 19207 RVA: 0x00023F05 File Offset: 0x00022105
		public Preset(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001657 RID: 5719
		// (get) Token: 0x06004B08 RID: 19208 RVA: 0x0016ED3C File Offset: 0x0016CF3C
		// (set) Token: 0x06004B09 RID: 19209 RVA: 0x00023F0E File Offset: 0x0002210E
		public unsafe string PresetName
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001658 RID: 5720
		// (get) Token: 0x06004B0A RID: 19210 RVA: 0x0016ED64 File Offset: 0x0016CF64
		// (set) Token: 0x06004B0B RID: 19211 RVA: 0x00023F2D File Offset: 0x0002212D
		public unsafe Color32 PresetColor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_PresetColor)) = value;
			}
		}

		// Token: 0x17001659 RID: 5721
		// (get) Token: 0x06004B0C RID: 19212 RVA: 0x0016ED8C File Offset: 0x0016CF8C
		// (set) Token: 0x06004B0D RID: 19213 RVA: 0x00023F48 File Offset: 0x00022148
		public unsafe ManageableObjectType ObjectType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_ObjectType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_ObjectType)) = value;
			}
		}

		// Token: 0x1700165A RID: 5722
		// (get) Token: 0x06004B0E RID: 19214 RVA: 0x0016EDB4 File Offset: 0x0016CFB4
		// (set) Token: 0x06004B0F RID: 19215 RVA: 0x00023F63 File Offset: 0x00022163
		public unsafe Preset.NameChange onNameChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onNameChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset.NameChange>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onNameChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700165B RID: 5723
		// (get) Token: 0x06004B10 RID: 19216 RVA: 0x0016EDE4 File Offset: 0x0016CFE4
		// (set) Token: 0x06004B11 RID: 19217 RVA: 0x00023F82 File Offset: 0x00022182
		public unsafe Preset.PresetDeletion onDeleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onDeleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset.PresetDeletion>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Preset.NativeFieldInfoPtr_onDeleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003290 RID: 12944
		private static readonly System.IntPtr NativeFieldInfoPtr_PresetName;

		// Token: 0x04003291 RID: 12945
		private static readonly System.IntPtr NativeFieldInfoPtr_PresetColor;

		// Token: 0x04003292 RID: 12946
		private static readonly System.IntPtr NativeFieldInfoPtr_ObjectType;

		// Token: 0x04003293 RID: 12947
		private static readonly System.IntPtr NativeFieldInfoPtr_onNameChanged;

		// Token: 0x04003294 RID: 12948
		private static readonly System.IntPtr NativeFieldInfoPtr_onDeleted;

		// Token: 0x04003295 RID: 12949
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003296 RID: 12950
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCopy_Public_Abstract_Virtual_New_Preset_0;

		// Token: 0x04003297 RID: 12951
		private static readonly System.IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Preset_0;

		// Token: 0x04003298 RID: 12952
		private static readonly System.IntPtr NativeMethodInfoPtr_InitializeOptions_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04003299 RID: 12953
		private static readonly System.IntPtr NativeMethodInfoPtr_SetName_Public_Void_String_0;

		// Token: 0x0400329A RID: 12954
		private static readonly System.IntPtr NativeMethodInfoPtr_DeletePreset_Public_Void_Preset_0;

		// Token: 0x0400329B RID: 12955
		private static readonly System.IntPtr NativeMethodInfoPtr_GetDefault_Public_Static_Preset_ManageableObjectType_0;

		// Token: 0x020009CE RID: 2510
		public sealed class NameChange : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CF21 RID: 53025 RVA: 0x00323994 File Offset: 0x00321B94
			// Note: this type is marked as 'beforefieldinit'.
			static NameChange()
			{
				Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preset>.NativeClassPtr, "NameChange");
				Preset.NameChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672686);
				Preset.NameChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672687);
				Preset.NameChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672688);
				Preset.NameChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr, 100672689);
			}

			// Token: 0x0600CF22 RID: 53026 RVA: 0x00323A08 File Offset: 0x00321C08
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 86967, RefRangeEnd = 86971, XrefRangeStart = 86967, XrefRangeEnd = 86971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NameChange(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset.NameChange>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF23 RID: 53027 RVA: 0x00323A64 File Offset: 0x00321C64
			[CallerCount(0)]
			public unsafe void Invoke(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF24 RID: 53028 RVA: 0x00323AA8 File Offset: 0x00321CA8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(string name, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CF25 RID: 53029 RVA: 0x00323B1C File Offset: 0x00321D1C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.NameChange.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF26 RID: 53030 RVA: 0x00064683 File Offset: 0x00062883
			public NameChange(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF27 RID: 53031 RVA: 0x0006468C File Offset: 0x0006288C
			public static implicit operator Preset.NameChange(System.Action<string> A_0)
			{
				return DelegateSupport.ConvertDelegate<Preset.NameChange>(A_0);
			}

			// Token: 0x0600CF28 RID: 53032 RVA: 0x00064694 File Offset: 0x00062894
			public static Preset.NameChange operator +(Preset.NameChange A_0, Preset.NameChange A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Preset.NameChange>();
			}

			// Token: 0x0600CF29 RID: 53033 RVA: 0x000646A2 File Offset: 0x000628A2
			public static Preset.NameChange operator -(Preset.NameChange A_0, Preset.NameChange A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Preset.NameChange>();
				}
				return result;
			}

			// Token: 0x04008C2C RID: 35884
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008C2D RID: 35885
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_String_0;

			// Token: 0x04008C2E RID: 35886
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_String_AsyncCallback_Object_0;

			// Token: 0x04008C2F RID: 35887
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020009CF RID: 2511
		public sealed class PresetDeletion : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600CF2A RID: 53034 RVA: 0x00323B60 File Offset: 0x00321D60
			// Note: this type is marked as 'beforefieldinit'.
			static PresetDeletion()
			{
				Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Preset>.NativeClassPtr, "PresetDeletion");
				Preset.PresetDeletion.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672690);
				Preset.PresetDeletion.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672691);
				Preset.PresetDeletion.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672692);
				Preset.PresetDeletion.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr, 100672693);
			}

			// Token: 0x0600CF2B RID: 53035 RVA: 0x00323BD4 File Offset: 0x00321DD4
			[CallerCount(90)]
			[CachedScanResults(RefRangeStart = 110018, RefRangeEnd = 110108, XrefRangeStart = 110018, XrefRangeEnd = 110108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PresetDeletion(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Preset.PresetDeletion>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF2C RID: 53036 RVA: 0x00323C30 File Offset: 0x00321E30
			[CallerCount(0)]
			public unsafe void Invoke(Preset replacement)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF2D RID: 53037 RVA: 0x00323C74 File Offset: 0x00321E74
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(Preset replacement, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(replacement);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600CF2E RID: 53038 RVA: 0x00323CE8 File Offset: 0x00321EE8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Preset.PresetDeletion.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF2F RID: 53039 RVA: 0x000646B3 File Offset: 0x000628B3
			public PresetDeletion(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600CF30 RID: 53040 RVA: 0x000646BC File Offset: 0x000628BC
			public static implicit operator Preset.PresetDeletion(System.Action<Preset> A_0)
			{
				return DelegateSupport.ConvertDelegate<Preset.PresetDeletion>(A_0);
			}

			// Token: 0x0600CF31 RID: 53041 RVA: 0x000646C4 File Offset: 0x000628C4
			public static Preset.PresetDeletion operator +(Preset.PresetDeletion A_0, Preset.PresetDeletion A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<Preset.PresetDeletion>();
			}

			// Token: 0x0600CF32 RID: 53042 RVA: 0x000646D2 File Offset: 0x000628D2
			public static Preset.PresetDeletion operator -(Preset.PresetDeletion A_0, Preset.PresetDeletion A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<Preset.PresetDeletion>();
				}
				return result;
			}

			// Token: 0x04008C30 RID: 35888
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04008C31 RID: 35889
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_Preset_0;

			// Token: 0x04008C32 RID: 35890
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_Preset_AsyncCallback_Object_0;

			// Token: 0x04008C33 RID: 35891
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}
	}
}
